using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_07_03
{
    public struct Bow : IWeapon
    {
        public string WeaponType => _type;
        private static readonly string _type = "Лук";

        public double Distance { get; set; }
        public double Accuracy { get; set; }

        public int WeaponStrenght { get; set; }
        public string SpecialWeaponFeatures { get; set; }
    }
}
