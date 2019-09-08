using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CursovSAOD
{
    class StaticList
    {
        Equipment[] nEquipment;
        public int Size { get; private set; }
        public int Count { get; private set; } = 0;
        public int WorkshopName { get; set; }

        public StaticList(int size) {
            Size = size;
            nEquipment = new Equipment[size];
        }
        public void Add(Equipment equipment)
        {
            if (Count < Size)
            {
                if (Count == 0)
                {
                    nEquipment[Count++] = equipment;
                }
                else {
                    int indexMax = 0;
                    int index = 0;
                    while (true) {
                        if (nEquipment[index].Count>equipment.Count) {
                            indexMax = index;
                            break;
                        }
                        if (nEquipment[index].Count <= equipment.Count)
                        {
                            indexMax = index+1;
                        }
                        if (index < Count-1)
                        {
                            index++;
                        }
                        else { break; }
                    }
                    int t = Count;
                    while (t != indexMax)
                    {
                        nEquipment[t--] = nEquipment[t];
                    }
                    nEquipment[indexMax] = equipment;
                    Count++;
                }
                
            }
            else {
                throw new Exception("Список переполнен");
            }
        }
        public Equipment Search(string equipment)
        {
            int temp = 0;
            while (temp < Count)
            {
                if (nEquipment[temp].Name.Equals(equipment))
                {
                    return nEquipment[temp];
                }
                else
                {
                    temp++;
                }
            }
            return null;
        }
        public void Remove(string nameEquipment)
        {
            if(Count==0) throw new Exception("Список оборудования пуст");
            int index = 0;
            while (index < Count) {
                if (nEquipment[index].Name.Equals(nameEquipment))
                {
                    break;
                }
                else
                {
                    index++;
                }
            }
            if (index < Count)
            {
                for (int i = index; i < Count; i++) {
                    if ((i + 1) < Count)
                    {
                        nEquipment[i] = nEquipment[i + 1];
                    }             
                }
                Count--;
            }
            else {
                throw new Exception("Удаляемый элемент не найден");
            }
        }
        public List<Equipment> toList() {
            List<Equipment> list = new List<Equipment>();
            for (int i = 0; i < Count; i++) {
                list.Add(nEquipment[i]);
            }
            return list;
        }
        public void Dispose_()
        {
            for (int i = 0; i < Size; i++) {
                nEquipment[i] = null;
            }
            Count = 0;
            Size = 0;
            GC.Collect();
        }
        ~StaticList()
        {
            Dispose_();
            GC.Collect();
        }
    }
}
