using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Group12405_Console_Lab9.Lab9_1
{
    abstract  class Item
    {
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;

        // истина, если этот предмет имеется в библиотеке
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        private void Take()
        {
            taken = false;
        }
        // операция "вернуть"
        abstract public void Return();
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        public void Show()
        {
            Console.WriteLine("\nСостояние единицы хранения:\n Инвентарный номер: {0}\n Наличие: {1}", invNumber, taken);
        }

        





    }
}
