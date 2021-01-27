using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.DataAccess;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer customer = new Student();
            ICustomer adult = new Adult() { Id = "12345", FirstName = "Ali", LastName = "Can", BirthYear = 1990, StudentId = "3223" };
            ISignUpManager signUpManager = new SignUpManager(new StudentServiceAdapter());

            signUpManager.CustomerAdd(new Student { Id = "345345", FirstName = "Ayşe", LastName = "Can", BirthYear = 1990, StudentId = "2334" }, new OracleServerDal());
            signUpManager.CustomerAdd(adult, new MySqlServerDal());

            ICampaignManager campaignManager = new CampaignManager();
            ICampaign campaign1 = new Campaign() { EntityName = "GAME" };
            IGame game1 = new Game() { EntityName = "Age Of Empires" };

            campaignManager.AddCampaign(campaign1, game1, adult, new MySqlServerDal());

            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(adult, game1, campaign1, new SMSLoggerService());
        }
    }

}
