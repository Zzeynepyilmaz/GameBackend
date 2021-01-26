using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface ICampaign
    {
        public int CampaignNumber { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
    }
}
