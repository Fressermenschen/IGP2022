using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass4.Scripts
{
    public class DefaultRifle : IRifle
    {
        private readonly int Damage = 100;

        public int GetRifleDamage()
        {
            return Damage;
        }
        
        public string GetRifleProperty()
        {
            return "Rifle";
        }
    }
}

