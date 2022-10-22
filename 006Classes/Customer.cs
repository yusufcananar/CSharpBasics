using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006Classes
{
    class Customer
    {
        public int _systemId;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int systemId 
        { 
            get 
            {
                return _systemId;
            }
            set 
            {
                _systemId = value;
            } 
        }
        
    }
}
