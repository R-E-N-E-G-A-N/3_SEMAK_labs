using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Logic
    {

        List<Gamer> gamers = new List<Gamer> ();

        public void AddGamer(string name, string iq, string balance) 
        {

            Gamer gamer = new Gamer() 
            {
            
                Name = name,
                IQ = iq,
                Balance = balance
            
            };
            gamers.Add(gamer);
        
        }

        public string GetAll() 
        {
        
            string s = string.Empty;
            foreach (Gamer gamer in gamers) 
            {

                s += gamer.Name + " " + gamer.IQ + " " + gamer.Balance + "\n";
            
            }
            return s;
        
        }

    }
}
