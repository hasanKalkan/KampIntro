using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class MernisServiceAdapter : BaseCheckService
    {
        public override bool ValidateStudentOrAdult(ICustomer customer)
        {
            Console.WriteLine("Search by name and lastname in anaother system");
            return true;
        }
    }
}
