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

        List<User> gamers = new List<User> ();

        public void AddUser(string name, int iq, int balance) 
        {

            User gamer = new User() 
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
            foreach (User gamer in gamers) 
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
                    gamers.Add(new User() 
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
