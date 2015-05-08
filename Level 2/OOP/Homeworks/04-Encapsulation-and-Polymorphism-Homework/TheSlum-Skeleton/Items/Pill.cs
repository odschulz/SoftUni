using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        public Pill(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 100)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}
