using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BaseCustomerManager customerManager = new NeroCustomerManager(); //nero checkservice istemiyor.
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 5, 11), FirstName = "Ali", LastName = "Can", NatioanalityId = "54378932152" });*/

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter()); //starbucks checkservise istiyor.
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1988, 4, 15), FirstName = "Hasan", LastName = "Can", NatioanalityId = "29132684644" });

            Console.ReadKey();
        }
    }
}
