using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Shared
{
    public class Unit
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Hitpoints { get; set; } = 100;

        public int BananaCost { get; set; }
    }
}
