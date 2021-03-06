﻿namespace RPG
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ChatMenu_tabPage = new System.Windows.Forms.TabPage();
            this.Chat_textBox = new System.Windows.Forms.TextBox();
            this.ChatSend_textBox = new System.Windows.Forms.TextBox();
            this.MapMenu_tabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Destination_listBox = new System.Windows.Forms.ListBox();
            this.CurrentRoom_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryMenu_tabPage = new System.Windows.Forms.TabPage();
            this.Inventory_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Gold_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Health_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Countdown_button = new System.Windows.Forms.Button();
            this.Countdown_label = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.InventoryMenu_button = new System.Windows.Forms.Button();
            this.MapMenu_button = new System.Windows.Forms.Button();
            this.ChatMenu_button = new System.Windows.Forms.Button();
            this.Players_listBox = new System.Windows.Forms.ListBox();
            this.Players_label = new System.Windows.Forms.Label();
            this.Countdown_timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.Armor_label = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.ChatMenu_tabPage.SuspendLayout();
            this.MapMenu_tabPage.SuspendLayout();
            this.InventoryMenu_tabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ChatMenu_tabPage);
            this.tabControl.Controls.Add(this.MapMenu_tabPage);
            this.tabControl.Controls.Add(this.InventoryMenu_tabPage);
            this.tabControl.Location = new System.Drawing.Point(142, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(356, 341);
            this.tabControl.TabIndex = 1;
            // 
            // ChatMenu_tabPage
            // 
            this.ChatMenu_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.ChatMenu_tabPage.Controls.Add(this.Chat_textBox);
            this.ChatMenu_tabPage.Controls.Add(this.ChatSend_textBox);
            this.ChatMenu_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ChatMenu_tabPage.Name = "ChatMenu_tabPage";
            this.ChatMenu_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChatMenu_tabPage.Size = new System.Drawing.Size(348, 315);
            this.ChatMenu_tabPage.TabIndex = 0;
            this.ChatMenu_tabPage.Text = "ChatMenu";
            // 
            // Chat_textBox
            // 
            this.Chat_textBox.Location = new System.Drawing.Point(7, 7);
            this.Chat_textBox.Multiline = true;
            this.Chat_textBox.Name = "Chat_textBox";
            this.Chat_textBox.ReadOnly = true;
            this.Chat_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat_textBox.Size = new System.Drawing.Size(335, 251);
            this.Chat_textBox.TabIndex = 2;
            // 
            // ChatSend_textBox
            // 
            this.ChatSend_textBox.Location = new System.Drawing.Point(7, 264);
            this.ChatSend_textBox.MaxLength = 128;
            this.ChatSend_textBox.Multiline = true;
            this.ChatSend_textBox.Name = "ChatSend_textBox";
            this.ChatSend_textBox.Size = new System.Drawing.Size(335, 45);
            this.ChatSend_textBox.TabIndex = 1;
            this.ChatSend_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatSend_textBox_KeyDown);
            // 
            // MapMenu_tabPage
            // 
            this.MapMenu_tabPage.BackColor = System.Drawing.Color.Transparent;
            this.MapMenu_tabPage.Controls.Add(this.label2);
            this.MapMenu_tabPage.Controls.Add(this.Destination_listBox);
            this.MapMenu_tabPage.Controls.Add(this.CurrentRoom_label);
            this.MapMenu_tabPage.Controls.Add(this.label1);
            this.MapMenu_tabPage.Location = new System.Drawing.Point(4, 22);
            this.MapMenu_tabPage.Name = "MapMenu_tabPage";
            this.MapMenu_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MapMenu_tabPage.Size = new System.Drawing.Size(348, 315);
            this.MapMenu_tabPage.TabIndex = 1;
            this.MapMenu_tabPage.Text = "MapMenu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gideceğin yer :";
            // 
            // Destination_listBox
            // 
            this.Destination_listBox.FormattingEnabled = true;
            this.Destination_listBox.Location = new System.Drawing.Point(10, 43);
            this.Destination_listBox.Name = "Destination_listBox";
            this.Destination_listBox.Size = new System.Drawing.Size(162, 95);
            this.Destination_listBox.TabIndex = 2;
            this.Destination_listBox.SelectedIndexChanged += new System.EventHandler(this.Destination_listBox_SelectedIndexChanged);
            // 
            // CurrentRoom_label
            // 
            this.CurrentRoom_label.AutoSize = true;
            this.CurrentRoom_label.Location = new System.Drawing.Point(101, 7);
            this.CurrentRoom_label.Name = "CurrentRoom_label";
            this.CurrentRoom_label.Size = new System.Drawing.Size(97, 13);
            this.CurrentRoom_label.TabIndex = 1;
            this.CurrentRoom_label.Text = "CurrentRoom_label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulunduğun yer :";
            // 
            // InventoryMenu_tabPage
            // 
            this.InventoryMenu_tabPage.Controls.Add(this.Armor_label);
            this.InventoryMenu_tabPage.Controls.Add(this.label6);
            this.InventoryMenu_tabPage.Controls.Add(this.Inventory_listBox);
            this.InventoryMenu_tabPage.Controls.Add(this.label5);
            this.InventoryMenu_tabPage.Controls.Add(this.Gold_label);
            this.InventoryMenu_tabPage.Controls.Add(this.label4);
            this.InventoryMenu_tabPage.Controls.Add(this.Health_label);
            this.InventoryMenu_tabPage.Controls.Add(this.label3);
            this.InventoryMenu_tabPage.Location = new System.Drawing.Point(4, 22);
            this.InventoryMenu_tabPage.Name = "InventoryMenu_tabPage";
            this.InventoryMenu_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryMenu_tabPage.Size = new System.Drawing.Size(348, 315);
            this.InventoryMenu_tabPage.TabIndex = 2;
            this.InventoryMenu_tabPage.Text = "Inventory";
            this.InventoryMenu_tabPage.UseVisualStyleBackColor = true;
            // 
            // Inventory_listBox
            // 
            this.Inventory_listBox.FormattingEnabled = true;
            this.Inventory_listBox.Location = new System.Drawing.Point(10, 57);
            this.Inventory_listBox.Name = "Inventory_listBox";
            this.Inventory_listBox.Size = new System.Drawing.Size(120, 95);
            this.Inventory_listBox.TabIndex = 5;
            this.Inventory_listBox.SelectedIndexChanged += new System.EventHandler(this.Inventory_listBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Envanter :";
            // 
            // Gold_label
            // 
            this.Gold_label.AutoSize = true;
            this.Gold_label.Location = new System.Drawing.Point(47, 24);
            this.Gold_label.Name = "Gold_label";
            this.Gold_label.Size = new System.Drawing.Size(13, 13);
            this.Gold_label.TabIndex = 3;
            this.Gold_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Altın :";
            // 
            // Health_label
            // 
            this.Health_label.AutoSize = true;
            this.Health_label.Location = new System.Drawing.Point(56, 7);
            this.Health_label.Name = "Health_label";
            this.Health_label.Size = new System.Drawing.Size(13, 13);
            this.Health_label.TabIndex = 1;
            this.Health_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sağlık :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Countdown_button);
            this.panel1.Controls.Add(this.Countdown_label);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.InventoryMenu_button);
            this.panel1.Controls.Add(this.MapMenu_button);
            this.panel1.Controls.Add(this.ChatMenu_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(139, 341);
            this.panel1.TabIndex = 2;
            // 
            // Countdown_button
            // 
            this.Countdown_button.Location = new System.Drawing.Point(3, 303);
            this.Countdown_button.Name = "Countdown_button";
            this.Countdown_button.Size = new System.Drawing.Size(133, 35);
            this.Countdown_button.TabIndex = 6;
            this.Countdown_button.Text = "Oyunu başlat";
            this.Countdown_button.UseVisualStyleBackColor = true;
            this.Countdown_button.Visible = false;
            this.Countdown_button.Click += new System.EventHandler(this.Countdown_button_Click);
            // 
            // Countdown_label
            // 
            this.Countdown_label.AutoSize = true;
            this.Countdown_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Countdown_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown_label.Location = new System.Drawing.Point(3, 313);
            this.Countdown_label.Name = "Countdown_label";
            this.Countdown_label.Size = new System.Drawing.Size(72, 25);
            this.Countdown_label.TabIndex = 5;
            this.Countdown_label.Text = "00 : 00";
            this.Countdown_label.Visible = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(3, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // InventoryMenu_button
            // 
            this.InventoryMenu_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryMenu_button.Location = new System.Drawing.Point(3, 73);
            this.InventoryMenu_button.Name = "InventoryMenu_button";
            this.InventoryMenu_button.Size = new System.Drawing.Size(133, 35);
            this.InventoryMenu_button.TabIndex = 2;
            this.InventoryMenu_button.Text = "Envanter";
            this.InventoryMenu_button.UseVisualStyleBackColor = true;
            this.InventoryMenu_button.Click += new System.EventHandler(this.InventoryMenu_button_Click);
            // 
            // MapMenu_button
            // 
            this.MapMenu_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MapMenu_button.Location = new System.Drawing.Point(3, 38);
            this.MapMenu_button.Name = "MapMenu_button";
            this.MapMenu_button.Size = new System.Drawing.Size(133, 35);
            this.MapMenu_button.TabIndex = 1;
            this.MapMenu_button.Text = "Harita";
            this.MapMenu_button.UseVisualStyleBackColor = true;
            this.MapMenu_button.Click += new System.EventHandler(this.MapMenu_button_Click);
            // 
            // ChatMenu_button
            // 
            this.ChatMenu_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatMenu_button.Location = new System.Drawing.Point(3, 3);
            this.ChatMenu_button.Name = "ChatMenu_button";
            this.ChatMenu_button.Size = new System.Drawing.Size(133, 35);
            this.ChatMenu_button.TabIndex = 0;
            this.ChatMenu_button.Text = "Sohbet";
            this.ChatMenu_button.UseVisualStyleBackColor = true;
            this.ChatMenu_button.Click += new System.EventHandler(this.ChatMenu_button_Click);
            // 
            // Players_listBox
            // 
            this.Players_listBox.FormattingEnabled = true;
            this.Players_listBox.Location = new System.Drawing.Point(505, 21);
            this.Players_listBox.Name = "Players_listBox";
            this.Players_listBox.Size = new System.Drawing.Size(115, 316);
            this.Players_listBox.TabIndex = 3;
            // 
            // Players_label
            // 
            this.Players_label.AutoSize = true;
            this.Players_label.Location = new System.Drawing.Point(505, 3);
            this.Players_label.Name = "Players_label";
            this.Players_label.Size = new System.Drawing.Size(61, 13);
            this.Players_label.TabIndex = 4;
            this.Players_label.Text = "Oyuncular :";
            // 
            // Countdown_timer
            // 
            this.Countdown_timer.Enabled = true;
            this.Countdown_timer.Interval = 1000;
            this.Countdown_timer.Tick += new System.EventHandler(this.Countdown_timer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zırh :";
            // 
            // Armor_label
            // 
            this.Armor_label.AutoSize = true;
            this.Armor_label.Location = new System.Drawing.Point(132, 7);
            this.Armor_label.Name = "Armor_label";
            this.Armor_label.Size = new System.Drawing.Size(13, 13);
            this.Armor_label.TabIndex = 7;
            this.Armor_label.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.Players_label);
            this.Controls.Add(this.Players_listBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.ChatMenu_tabPage.ResumeLayout(false);
            this.ChatMenu_tabPage.PerformLayout();
            this.MapMenu_tabPage.ResumeLayout(false);
            this.MapMenu_tabPage.PerformLayout();
            this.InventoryMenu_tabPage.ResumeLayout(false);
            this.InventoryMenu_tabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ChatMenu_tabPage;
        private System.Windows.Forms.TabPage MapMenu_tabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChatMenu_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button InventoryMenu_button;
        private System.Windows.Forms.Button MapMenu_button;
        private System.Windows.Forms.Label Players_label;
        public System.Windows.Forms.ListBox Players_listBox;
        public System.Windows.Forms.TextBox ChatSend_textBox;
        public System.Windows.Forms.TextBox Chat_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentRoom_label;
        private System.Windows.Forms.ListBox Destination_listBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Countdown_button;
        public System.Windows.Forms.Label Countdown_label;
        private System.Windows.Forms.Timer Countdown_timer;
        private System.Windows.Forms.TabPage InventoryMenu_tabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Health_label;
        private System.Windows.Forms.Label Gold_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Inventory_listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Armor_label;
    }
}