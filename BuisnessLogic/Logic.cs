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

        public void AddGamer(string name, int iq, int balance) 
        {

            Gamer gamer = new Gamer() 
            {
            
                Name = name,
                IQ = iq,
                Balance = balance
            
            };
            gamers.Add(gamer);
        
        }

        public List<string> GetAll() 
        {
        
            List<string> s = new List<string>();
            foreach (Gamer gamer in gamers) 
            {

                s.Add(gamer.Name + " " + gamer.IQ + " " + gamer.Balance);
            
            }
            return s;
        
        }

    }
}
