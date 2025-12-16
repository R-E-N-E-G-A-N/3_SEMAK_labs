using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Logic
    {

        List<Quest> quests = new List<Quest>();
        List<string> tips = new List<string>();

        public void AddQuest(string name, string day, string place)
        {

            Quest quest = new Quest()
            {

                ID = quests.Count,
                Name = name,
                Day = day,
                Place = place

            };

            Console.WriteLine(quest.ID);
            quests.Add(quest);
        
        }

        public List<string> GetAll() 
        {
        
            var list = new List<string>();
            foreach (Quest quest in quests) 
            {
                
                list.Add($"{quest.Name}.{quest.Day}.{quest.Place}.{quest.ID}");
            
            }
            return list;
        
        }

        public void ChangeQuest(string name, string day, string place, int id) 
        {

            foreach (Quest quest in quests)
            {

                if(quest.ID == id) 
                {
                
                    quest.Name = name;
                    quest.Day = day;
                    quest.Place = place;
                    break;

                }

            }
        
        }

        public void DeleteQuest(int id) 
        {
        
            foreach(Quest quest in quests) 
            {
            
                if (quest.ID == id) 
                {
                
                    quests.Remove(quest);
                    break;
                    
                }
            
            }
            int count = 0;
            foreach (Quest quest in quests)
            {

                quest.ID = count;
                count++;

            }

        }

        public void AddTip(string tip, int id) 
        {
        
            tips.Add($"{tip}.{id}");
        
        }
        public string GetTip(int id) 
        {

            string tip_ = "";

            foreach (string tip in tips) 
            {
            
                var list = tip.Split('.');
                if (list[1] == id.ToString()) 
                {
                
                    tip_ = list[0];
                    break;
                
                }
            
            }

            return tip_;
        
        }

    }
}
