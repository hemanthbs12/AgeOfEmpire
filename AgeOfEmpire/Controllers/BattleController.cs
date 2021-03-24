using AgeOfEmpire.Domain.Models;
using AgeOfEmpire.Domain.Services;
using AgeOfEmpire.ServiceGateway;
using AgeOfEmpire.ServiceModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AgeOfEmpire.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BattleController : ControllerBase
    {
        private readonly IBattleService _battleService;
        private readonly IAgeOfEmpireGateway _ageOfEmpireGateway;
        private readonly IMapper _mapper;
        public BattleController(IBattleService battleService, IAgeOfEmpireGateway ageOfEmpireGateway, IMapper mapper)
        {
            _battleService = battleService;
            _ageOfEmpireGateway = ageOfEmpireGateway;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/battle/getwinner")]
        [Description("gets the winning unit of the random two units")]
        public ActionResult<UnitDTO> GetWinner()
        {
            var units = new List<Unit>();
            //get two random units
            //this can be scaled to multiple unit logic
            units = GetRandomUnits(2);

            //get the winner
            var winner = _battleService.GetWinner(units);
            return _mapper.Map<UnitDTO>(winner);
        }

        private List<Unit> GetRandomUnits(int numberOfUnits)
        {
            Random randomInt = new Random();
            var units = new List<Unit>();
            for (int i = 0; i < numberOfUnits; i++)
            {
                var unit = _ageOfEmpireGateway.GetUnit(randomInt.Next(0, 100));
                units.Add(new Unit(unit.Id, unit.Name, unit.HitPoints, unit.Attack));
            }
            return units;
        }
    }
}
