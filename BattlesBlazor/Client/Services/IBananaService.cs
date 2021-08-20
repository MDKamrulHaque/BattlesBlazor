﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Client.Services
{
    public interface IBananaService
    {
        event Action OnChange;
        int Bananas { get; set; }
        void EatBananas(int amount);
        Task AddBananas(int amount);
        Task GetBananas();

    }
}
