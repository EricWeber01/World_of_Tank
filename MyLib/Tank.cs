using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Tank
    {
        public Tank() { }
        public Tank(string _name, int _armor, int _ammo, int _speed)
        {
            name = _name;
            armor = _armor;
            ammo = _ammo;
            speed = _speed;
        }
        public static bool operator *(Tank t1, Tank t2)
        {
            if ((t1.armor > t2.armor && t1.ammo > t2.ammo) || (t1.armor > t2.armor && t1.speed > t2.speed) || (t1.speed > t2.speed && t1.ammo > t2.ammo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {

            return $"{name} | Sp:{speed} | Arm:{armor} | Am:{ammo}";
        }
        public string name;
        public int armor;
        public int ammo;
        public int speed;
    }
}