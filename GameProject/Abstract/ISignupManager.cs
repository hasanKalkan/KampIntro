using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISignupManager
    {
        void CustomerAdd(ICustomer customer, IDatabaseDal databaseDal);
        void CustomerUpdate(ICustomer customer, IDatabaseDal databaseDal);
        void CustomerDelete(ICustomer customer, IDatabaseDal databaseDal);

    }
}
