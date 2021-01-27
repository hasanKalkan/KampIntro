using GameProject.Abstract;
using GameProject.DataAccess;
using GameProject.Entities;

namespace GameProject
{
    internal interface ISignUpManager
    {
        void CustomerAdd(Student student, OracleServerDal oracleServerDal);
        void CustomerAdd(ICustomer adult, MySqlServerDal mySqlServerDal);
    }
}