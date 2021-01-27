using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
   public interface ICustomer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string StudentId { get; set; }
    }
}
