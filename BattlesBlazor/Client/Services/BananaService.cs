using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Bananas { get; set; } = 1000;

        public void EatBananas(int amount)
        {
            Bananas -= amount;
            BananaChanged();
        }
        void BananaChanged() => OnChange.Invoke();

        public void AddBananas(int amount)
        {
            Bananas += amount;
            BananaChanged();
        }
    }

}
