using MernisServiceReference;
using System;
using MernisServiceReference;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCheckService : ICustomerCheckService
    {
        public abstract bool ValidateStudentOrAdult(ICustomer customer);
        
        public bool ValidateOrAdult(ICustomer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.Id), customer.FirstName, customer.LastName, customer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
