using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Logic
    {

        List<Quest> quests = new List<Quest>();

        public void AddQuest(string name, string day, string place)
        {

            Quest quest = new Quest() 
            {

                ID = quests.Count,
                Name = name,
                Day = day,
                Place = place

            };

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

    }
}
