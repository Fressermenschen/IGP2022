using System;
using System.Collections;
using System.Collections.Generic;
using Ass4.Scripts.Decorators;
using UnityEngine;

namespace Ass4.Scripts
{
    public class RifleControl : MonoBehaviour
    {
        private IRifle _rifle;

        private void Awake()
        {
            _rifle = new DefaultRifle();
            PrintStats();
            
            _rifle = new RifleScope(_rifle);
            PrintStats();

            _rifle = new RifleSilencer(_rifle);
            PrintStats();

            _rifle = new ApRifleAmmo(_rifle);
            PrintStats();
        }
        
        public void PrintStats()
        {
            Debug.Log(_rifle.GetRifleDamage() +  "\n" + _rifle.GetRifleProperty());
        }
    }
}
