﻿using BattlesBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Client.Services
{
   public interface IBattleService
    {
        BattleResult LastBattle { get; set; }
        IList<BattleHistoryEntry> History { get; set; }
        Task<BattleResult> StartBattle(int opponentId);
        Task GetHistory();
    }
}
