using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace _8marta
{
    public class Buket
    {
        public double Cost { get; set; }
        public List<Item> Elements { get; set; }

        public void RCost() //Расчет начальной стоимости букета
        {
            Cost = 0;
            foreach (var el in Elements)
            {
                Cost += el.Cost;
            }
            Cost = Cost / 100 * 80;
        }

        public void Ubrat(Item item)
        {
            if (Elements.Contains(item))
                if (Cost - item.Cost > 0)
                {
                    Elements.Remove(item);
                    this.Cost -= item.Cost;

                }
                else
                {
                    Console.WriteLine(
                        "Если вы удалите этот элемент, то стоимость будет меньше 0. Вы уверены?\n1. Да\n2. Нет");

                    var q = Console.ReadLine();
                    if (q == "1")
                    {
                        Elements.Remove(item);
                        this.Cost -= item.Cost;
                    }
                }

            /*foreach (item I in Elements)
            {
                if (item.type == I.type)
                {
                    
                }
            }*/
        }
    }
}
