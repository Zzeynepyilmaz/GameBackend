using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class CampaignManager:ICampaignManager
    {
        public void Add(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya eklendi.");
            Console.WriteLine("Kampanya Bilgileri: ");
            Console.WriteLine("Kampanya Numarası: " + campaign.CampaignNumber);
            Console.WriteLine("Kampanya Adı: " + campaign.Name);
            Console.WriteLine("Kampanya Süresi(Gün): " + campaign.Day);
            Console.WriteLine("------------------");
        }
        public void Update(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya güncellendi.");
            Console.WriteLine("------------------");
        }
        public void Delete(ICampaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya silindi.");
            Console.WriteLine("------------------");
        }

    }
}
