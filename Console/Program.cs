using BuisnessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logic logic = new Logic();

            Console.WriteLine("Введите цель квеста:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите день недели:");
            string day = Console.ReadLine();
            Console.WriteLine("Введите место квеста:");
            string place = Console.ReadLine();

            logic.AddQuest(name, day, place);

        }
    }
}
