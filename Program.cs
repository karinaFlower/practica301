using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika301
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 USER = new Class1(20, 345, "Гребенькова Карина Юрьевна",143 ,"Ваша фотография"); 

            Console.WriteLine($"Возраст пользователя {USER.ReturnVozrast()} ");
            Console.WriteLine($"Логин {USER.Returnlogin()} "); 
            Console.WriteLine($"ФИО пользователя {USER.ReturnFio()} "); 
            Console.WriteLine($"Пароль {USER.ReturnParol()} ");
            Console.WriteLine($"Аватар {USER.ReturnAvatar()} ");
            Console.WriteLine("Введите новое ФИО  _"); USER.SetFio(Console.ReadLine());
            Console.WriteLine($"Ваше новое ФИО {USER.ReturnFio()}");
          
            Console.ReadLine();

        }
    }
}
