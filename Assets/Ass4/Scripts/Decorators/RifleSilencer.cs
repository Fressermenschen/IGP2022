using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ass4.Scripts.Decorators
{
    public class RifleSilencer : RifleDecorator
    {
        public RifleSilencer(IRifle rifle) : base(rifle)
        {
        }

        public override int GetRifleDamage()
        {
            return base.GetRifleDamage() - 5;
        }

        public override string GetRifleProperty()
        {
            return base.GetRifleProperty() + " Shoots Are Silent";
        }
    }
}
