using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //field tanımlama - bu özellik pek kullanılmaz.
        //public string FirstName; //class içinde özellik tanımlanacaksa aşağıdaki property özelliği kullanılır. 

        //propperty tanımlama
        public int Id { get; set; }
        private string _firstName;
        public string FirstName { 
            get { return "Mrs. "+_firstName; }  //değerin başına Mrs ekledik
            set { _firstName = value; } 
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
