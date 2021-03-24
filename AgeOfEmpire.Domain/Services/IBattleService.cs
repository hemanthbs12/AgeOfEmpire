using AgeOfEmpire.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfEmpire.Domain.Services
{
    public interface IBattleService
    {
        Unit GetWinner(List<Unit> units);

    }
}
