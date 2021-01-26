using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class PlayerManager : IPlayerManager
    {
        public void Add(IPlayer player)
        {
            Console.WriteLine(player.PlayerName +" isimli oyuncu eklendi.");
            Console.WriteLine("------------------");
        }
        public void Update (IPlayer player)
        {
            Console.WriteLine(player.PlayerName + " isimli oyuncu güncellendi.");
            Console.WriteLine("------------------");
        }
        public void Delete(IPlayer player)
        {
            Console.WriteLine(player.PlayerName + " isimli oyuncu silindi.");
            Console.WriteLine("------------------");
        }

    }
}
