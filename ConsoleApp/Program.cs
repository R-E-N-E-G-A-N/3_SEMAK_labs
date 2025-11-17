using BuisnessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logic logic = new Logic();
            Console.WriteLine("Введите имя пользоватеоля:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите iq пользователя:");
            string iq = Console.ReadLine();
            Console.WriteLine("Введите баланс пользователя:");
            string balance = Console.ReadLine();
            logic.AddGamer(name, iq, balance);

        }
    }
}
