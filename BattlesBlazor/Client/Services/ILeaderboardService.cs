using BattlesBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattlesBlazor.Client.Services
{
    public interface ILeaderboardService
    {
         IList<UserStatistic> Leaderboard { get; set; }
        Task GetLeaderboard();

    }
}
