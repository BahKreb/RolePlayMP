﻿using RolePlayMP.src.Inventory;
using RPG.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolePlayMP.src
{
    public class RoomEffect
    {
        public void Effect(ref PlayerMP player, int effectIndex, int effectModifier)
        {
            switch (effectIndex)
            {
                case 0:     // No effect
                    break;
                case 1:     // Heal player
                    player.health += effectModifier;
                    break;
                case 2:     // Give gold to player
                    player.gold += effectModifier;
                    break;
                case 3:     // Give a random item to player
                    Random random = new Random();
                    player.inventory.AddItem(random.Next(Item.itemNumber));
                    break;
                default:    // No effect
                    break;
            }
        }
    }
}
