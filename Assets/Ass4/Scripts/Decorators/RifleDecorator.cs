using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Ass4.Scripts;
using UnityEngine;

namespace Ass4.Scripts.Decorators
{
    public class RifleDecorator : IRifle
    {
        private readonly IRifle _modifiedRifle;

        protected RifleDecorator(IRifle rifle)
        {
            _modifiedRifle = rifle;
        }

        public new virtual int GetRifleDamage()
        {
            return _modifiedRifle.GetRifleDamage();
        }

        public new virtual string GetRifleProperty()
        {
            return _modifiedRifle.GetRifleProperty();
        }
    }
}


