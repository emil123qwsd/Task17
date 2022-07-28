using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Bank<T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public int Summa { get; set; }

        public string GetInfoC()
        {
            Console.WriteLine("Тип счета: текущиий");//Текущий счет пример:123456
            return $"Номер счета: {Num}, ФИО: {Name}, Баланс: {Summa}";
        }
        public string GetInfoS()
        {
            Console.WriteLine("Тип счета: сберегательный");//Сберегательный счет пример:ТН1234АП
            return $"Номер счета: {Num}, ФИО: {Name}, Баланс: {Summa}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Summa = Convert.ToInt32(Console.ReadLine());
        }

        
    }
}
