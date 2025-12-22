using DataAccesLayer;
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

        IReposytory<Quest> quests = new EntityRepository<Quest>();
        List<string> tips = new List<string>();

        public void AddQuest(string name, string day, string place)
        {

            Quest quest = new Quest()
            {

                ID = quests.GetReposytory().Count(),
                Name = name,
                Day = day,
                Place = place

            };

            quests.Create(quest);
            quests.Save();
        
        }

        public List<string> GetAll() 
        {
        
            var list = new List<string>();
            foreach (Quest quest in quests.GetReposytory()) 
            {
                
                list.Add($"{quest.Name}.{quest.Day}.{quest.Place}.{quest.ID}");
            
            }
            return list;
        
        }

        public void ChangeQuest(string name, string day, string place, int id) 
        {

            quests.Update(new Quest() 
            {
            
                Name = name,
                Day = day,
                Place = place,
                ID = id
            
            });
        
        }

        public void DeleteQuest(int id) 
        {
        
            foreach(Quest quest in quests.GetReposytory()) 
            {
            
                if (quest.ID == id) 
                {
                
                    quests.Delete(quest);
                    break;
                    
                }
            
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
