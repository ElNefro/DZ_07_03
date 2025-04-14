using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_07_03
{
    public interface IWeapon
    {
        static string WeaponType { get; }
        int WeaponStrenght { get; set; }
        string SpecialWeaponFeatures { get; set; }

        public string GetInfo() => $"Оружие: {WeaponType}, Сила оружия: {WeaponType}, Особые возможности оружия: {SpecialWeaponFeatures}";

    }
}
