﻿using RolePlayMP.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RPG.src
{
    public class GameClient
    {
        private TcpListener clientListener;

        private Form2 gameForm;

        private PlayerMP player;
        private String ipAddress;
        private int serverPort;

        public GameClient(Form2 gameForm, ref PlayerMP player, String ipAddress, int serverPort)
        {
            this.gameForm = gameForm;
            this.player = player;
            this.ipAddress = ipAddress;
            this.serverPort = serverPort;
            try
            {
                clientListener = new TcpListener(IPAddress.Any, player.port);
                clientListener.Start();
                Thread thread = new Thread(new ThreadStart(Run));
                thread.IsBackground = true; // Thread closes when the windows are closed
                thread.Start();
            }
            catch (Exception) { }
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024];
                    TcpClient client = clientListener.AcceptTcpClient();
                    client.ReceiveTimeout = 500;
                    client.Client.Receive(data);

                    ParsePacket(data);
                    client.Close();
                }
                catch (Exception) { }
            }
        }

        public void ParsePacket(byte[] data)
        {
            String dataStr = System.Text.ASCIIEncoding.UTF8.GetString(data).Trim();
            Packet.PacketTypes type = Packet.FindPacket(dataStr.Substring(0, 2));
            switch (type)
            {
                case Packet.PacketTypes.INVALID:
                    break;
                case Packet.PacketTypes.LOGIN:
                    Packet00Login loginPacket = new Packet00Login(data);
                    HandleLogin(loginPacket);
                    break;
                case Packet.PacketTypes.DISCONNECT:
                    Packet01Disconnect disconnectPacket = new Packet01Disconnect(data);
                    HandleDisconnect(disconnectPacket);
                    break;
                case Packet.PacketTypes.MESSAGE:
                    Packet02Message messagePacket = new Packet02Message(data);
                    HandleMessage(messagePacket);
                    break;
                case Packet.PacketTypes.ROUND_START:
                    HandleRoundStart();
                    break;
                case Packet.PacketTypes.ROUND_END:
                    Packet04RoundEnd roundEndPacket = new Packet04RoundEnd(data);
                    HandleRoundEnd(roundEndPacket);
                    break;
            }
        }

        private void HandleLogin(Packet00Login loginPacket)
        {
            gameForm.Players_listBox.Items.Add(loginPacket.GetUsername());
        }

        private void HandleDisconnect(Packet01Disconnect disconnectPacket)
        {
            gameForm.Players_listBox.Items.Remove((object)disconnectPacket.GetUsername());
        }

        private void HandleMessage(Packet02Message messagePacket)
        {
            gameForm.Chat_textBox.Text += messagePacket.GetUsername() + " : " + messagePacket.GetMessage() + Environment.NewLine;
            int caretPos = gameForm.Chat_textBox.Text.Length;
            gameForm.Chat_textBox.Select(caretPos, 0);
            gameForm.Chat_textBox.ScrollToCaret();
        }

        private void HandleRoundStart()
        {
            gameForm.SetTimer();
        }

        private void HandleRoundEnd(Packet04RoundEnd roundEndPacket)
        {
            Room.SetCurrentRoom(Room.GetRoomIndex(roundEndPacket.GetDestination()));
            Room.Effect(ref player);

            if (int.Parse(roundEndPacket.GetItemIndex()) != -1)
                player.inventory.UseItem(ref player, int.Parse(roundEndPacket.GetItemIndex()));

            gameForm.ReloadMap();
            gameForm.ReloadInventory();
        }

        public void SendData(byte[] data)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(ipAddress, serverPort);
                client.SendTimeout = 500;
                client.Client.Send(data);
                client.Close();
            }
            catch (Exception) { }
        }
    }
}