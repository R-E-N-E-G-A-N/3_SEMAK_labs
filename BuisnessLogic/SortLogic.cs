using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class SortLogic
    {

        List<string> sortedList = new List<string>();

        public List<string> Sort(List<string> list, string filter) 
        {

            sortedList.Clear();
            if (filter != "")
            {

                foreach (var item in list)
                {

                    var s = item.Split('.');
                    if (s.Contains(filter))
                    {

                        sortedList.Add(item);

                    }

                }

            }
            else
            {

                sortedList = list;

            }
            return sortedList;
        
        }

    }
}
