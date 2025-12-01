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

        public void DeleteUser(string nickname)
        {

            foreach (var gamer in gamers) 
            {

                if (gamer.Name == nickname) 
                {
                
                    gamers.Remove(gamer);
                    break;
                
                }
            
            }

        }

        public void ChangeUser(string nickname, int iq, int balance) 
        {

            foreach (var gamer in gamers) 
            {
            
                if (gamer.Name == nickname)
                {

                    gamers.Remove(gamer);
                    gamers.Add(new Gamer() 
                    {

                        Name = nickname,
                        IQ = iq,
                        Balance = balance

                    });

                }
            
            }

        }

        public bool CheckUser(string nickname) 
        {

            foreach(var gamer in gamers) 
            {
                
                if (gamer.Name.Equals(nickname)) 
                {
                
                    return true;
                
                }
                else 
                {
                
                    return false;
                
                }
            
            }
            return false;

        }

    }
}
