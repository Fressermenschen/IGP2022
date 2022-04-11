using System.Collections;
using System.Collections.Generic;
using Ass4.Scripts;
using Ass4.Scripts.Decorators;
using UnityEngine;

namespace Ass4.Scripts.Decorators
{
    public class RifleScope : RifleDecorator
    {
        public RifleScope(IRifle rifle) : base(rifle)
        {
        }

        public override string GetRifleProperty()
        {
            return base.GetRifleProperty() + " Accuracy Increased by 50%";
        }
    }
}


