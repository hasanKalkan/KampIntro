﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesManager
    {
        void Sell(ICustomer customer, IGame game, ICampaign campaign, ILoggerService loggerService);
        void CancelSale(ICustomer customer, ILoggerService loggerService);
    }
}
