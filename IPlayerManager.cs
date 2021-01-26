using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IPlayerManager
    {
        void Add(IPlayer player);
        void Update(IPlayer player);
        void Delete(IPlayer player);
    }
}
