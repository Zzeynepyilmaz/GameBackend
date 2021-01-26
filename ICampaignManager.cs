using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface ICampaignManager
    {
        void Add(ICampaign campaign);
        void Update(ICampaign campaign);
        void Delete(ICampaign campaign);
        
    }
}
