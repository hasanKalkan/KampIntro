using System;

namespace Interfaces2
{
    class Program
    {

        static void Main(string[] args)
        {
            //IPersonManager personManager = new PersonManager(); //Interface new lenemez.

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            // CustomerManager customerManager = new CustomerManager();
            //  EmployeeManager employeeManager = new EmployeeManager();

            // ProjectManager projectManager = new ProjectManager();
            // projectManager.AddEmployee(employeeManager);
            //  projectManager.AddCustomer(customerManager);


            /* IPersonManager customerManager = new CustomerManager();
             IPersonManager employeeManager = new EmployeeManager();
             ProjectManager projectManager = new ProjectManager();
             projectManager.Add(customerManager);
             projectManager.Add(employeeManager);*/

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());

        }
    }


    /*class PersonManager
    {
        //implemented operation: içi doldurulmuş, implemente edilmiş
        public void Add() //class larda buranın içi doludur. interface lerde boştur.
        {

        }

    }*/

    interface IPersonManager //Interface de üyeler oluyor ama içi boş oluyor. 
    {
        //unimplemented operation
         void Add();  //default kısmı public olduğu için yazdırmaz. interface üyeleri dışarıdan erişilebilir olmalıdır.
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri eklendi.");
        }
    }

    //inherits-class----------------implements-interface
    class EmployeeManager : IPersonManager  //yanındaki ampüle tıklayıp implement interface tıkladık.
    {
        public void Add() //interface den çekildi.
        {
            Console.WriteLine("İşçi eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("İşçi güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer eklendi.");
        }
    }

    class ProjectManager
    {
      /*  public void AddCustomer(CustomerManager CustomerManager)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
        }

        public void AddEmployee(EmployeeManager EmployeeManager)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Add();
        }*/


        public void Add(IPersonManager personManager) //yukardaki kodlara kadar bu kodu yazarız. hepsini kapsa
        {
            personManager.Add();
        }
    }

}

