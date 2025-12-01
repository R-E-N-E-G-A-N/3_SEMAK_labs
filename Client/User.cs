using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model

{
    /// <summary>
    /// Сущность геймера, реализующая интерфейс IDomainObject
    /// </summary>
    public class Gamer : DataAccessLayer.IDomainObject
    {
        public int Id { get; set; }

        public string Name { set; get; }

        public int IQ { set; get; }

        public int Balance { set; get; }

    }
}
