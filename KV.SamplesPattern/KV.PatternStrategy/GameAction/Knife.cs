﻿using System;

namespace KV.PatternStrategy.GameAction
{
    public class Knife : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cortar com uma faca!");                       
        }
    }
}