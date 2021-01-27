using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignManager
    {
        void AddCampaign(ICampaign campaign, IGame game, ICustomer customer, IDatabaseDal databaseDal);
        void UpdateCampaign(ICampaign campaign, IGame game, ICustomer customer, IDatabaseDal databaseDal);
        void DeleteCampaign(ICampaign campaign, IGame game, ICustomer customer, IDatabaseDal databaseDal);
    }
}
