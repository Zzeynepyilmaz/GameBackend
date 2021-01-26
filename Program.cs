using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.TcNumber = "1234567890";
            player1.Name = "Zeynep";
            player1.Surname = "Yılmaz";
            player1.PlayerName = "Zzeynepyilmaz";
            player1.BirthDay = 2001;

            Player player2 = new Player();
            player2.TcNumber = "1234569870";
            player2.Name = "Berat";
            player2.Surname = "Yılmaz";
            player2.PlayerName = "Beratyilmaz";
            player2.BirthDay = 2004;

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignNumber = 1;
            campaign1.Name = "Karne İndirimi";
            campaign1.Day = 2;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignNumber = 2;
            campaign2.Name = "Yeni Yıl İndirimi";
            campaign2.Day = 14;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            

        }
    }
}
