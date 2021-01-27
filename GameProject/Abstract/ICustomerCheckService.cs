using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICustomerCheckService
    {
        bool ValidatePerson(ICustomer customer);
        bool ValidateStudentOrAdult(ICustomer customer);
    }
}
