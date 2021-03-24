using AgeOfEmpire.ServiceModel;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AgeOfEmpire.ServiceGateway
{
    public class AgeOfEmpireGateway : BaseGateway, IAgeOfEmpireGateway
    {

        public UnitDTO GetUnit(int unitId)
        {
            var requestUri = $"https://age-of-empires-2-api.herokuapp.com/api/v1/unit/{unitId}";
            var unit = GetAsync<UnitDTO>(requestUri);
            return unit;
        }
    }
}
