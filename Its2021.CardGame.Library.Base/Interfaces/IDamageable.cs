using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.CardGame.Library.Base.Interfaces
{
    public interface IDamageable
    {
        int GetDamage(int amount);
        int HealthPoint { get; }
    }
}
