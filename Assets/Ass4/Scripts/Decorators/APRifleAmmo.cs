using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass4.Scripts.Decorators
{
    public class ApRifleAmmo : RifleDecorator
    {
        public ApRifleAmmo(IRifle rifle) : base(rifle)
        {
        }

        public override int GetRifleDamage()
        {
            return base.GetRifleDamage() - 20;
        }

        public override string GetRifleProperty()
        {
            return base.GetRifleProperty() + " Armor Penetration Increased by 300%";
        }
    }
}
