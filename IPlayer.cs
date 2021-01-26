using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IPlayer
    {
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PlayerName { get; set; }
        public int BirthDay { get; set; }

    }
}
