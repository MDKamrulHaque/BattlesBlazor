using BattlesBlazor.Shared;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BattlesBlazor.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _http;

        public UnitService(IToastService toastService, HttpClient http)
        {
          _toastService = toastService;
            _http = http;
        }
        public IList<Unit> Units { get; set; } = new List<Unit>();

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();
    
        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.Hitpoints });
            _toastService.ShowSuccess($"Your {unit.Title} has been built!");




        }

        public async Task LoadUnitAsync()
        {
            if(Units.Count == 0)
            {
                Units = await _http.GetFromJsonAsync<IList<Unit>>("api/Unit");
            }
        }
    }
}
