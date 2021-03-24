using AgeOfEmpire.ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfEmpire.ServiceGateway
{
    public interface IAgeOfEmpireGateway
    {
        UnitDTO GetUnit(int unitId);
    }
}
