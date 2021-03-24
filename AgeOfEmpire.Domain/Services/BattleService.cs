using AgeOfEmpire.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfEmpire.Domain.Services
{
    public class BattleService : IBattleService
    {

        public Unit GetWinner(List<Unit> units)
        {
            //fixture algorithm could be implemented to handle more than 2 teams
            var winner = getWinnerOutOfTwoTeams(units[0], units[1]);
            return winner;
        }

        private Unit getWinnerOutOfTwoTeams(Unit unit1, Unit unit2)
        {
            if(unit2.HitPoints/unit1.Attack < unit1.HitPoints / unit2.Attack)
            {
                return unit1;
            }
            else
            {
                return unit2;
            }
        }
    }
}
