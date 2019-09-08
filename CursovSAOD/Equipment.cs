using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursovSAOD
{
    class Equipment
    {
        private string _NameEquipment;
        private int _CountEquipment;

        public string Name { get { return _NameEquipment; } set { _NameEquipment = value; } }
        public int Count { get { return _CountEquipment; } set { _CountEquipment = value; } }

        public Equipment(string name, int count)
        {
            Name = name;
            Count = count;
        }
        ~Equipment()
        {
            Name = null;
            Count = 0;
        }
    }
}
