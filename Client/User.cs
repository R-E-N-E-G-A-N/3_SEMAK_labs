using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model

{
    public class User : IDomainObject
    {

        public string Name { set; get; }

        public int IQ { set; get; }

        public int Balance { set; get; }

        public int Id { get; set; }
    }
}
