using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        //В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
        //метод получает входным параметром переменную типа double;
        //метод возвращает значение типа double, которое является результатом вычисления.
        //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        //длину окружности по формуле D = 2 * π * R;
        //площадь круга по формуле S = π* R²;
        //объем шара.Формула V = 4 / 3 * π * R³.
        //Методы должны быть объявлены как статические.

        delegate double Mydelegate(double r);


        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Mydelegate mydelegate = DlinaOkr;
            double rez = mydelegate(r);
            Console.WriteLine($"Длина окружности равна {rez}");

            mydelegate = PloshKruga;
            rez = mydelegate(r);
            Console.WriteLine($"Площадь круга равна {rez}");

            mydelegate = ObShara;
            rez = mydelegate(r);
            Console.WriteLine($"Объем шара равен {rez}");

            Console.ReadKey();
        }
        static double DlinaOkr(double r) => (2*Math.PI*r);
        static double PloshKruga(double r) => (Math.PI * r*r);
        static double ObShara(double r) => ((((double)4)/3)*Math.PI * Math.Pow(r,3));
    }
}
