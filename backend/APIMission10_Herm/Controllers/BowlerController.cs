using APIMission10_Herm.Something;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIMission10_Herm.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }
        public class BowlerTeamData
        {
            public int BowlerId { get; set; }
            public string BowlerName { get; set; }
            public string TeamName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
        }

        public IEnumerable<BowlerTeamData> Get()
        {
            var bowlerData = from bowler in _bowlerRepository.Bowlers
                             join team in _bowlerRepository.Teams
                             on bowler.TeamId equals team.TeamId into bowlerTeam
                             from bt in bowlerTeam.DefaultIfEmpty()
                             where bt != null && (bt.TeamId == 1 || bt.TeamId == 2) // Filter by TeamId 1 or 2
                             select new BowlerTeamData
                             {
                                 BowlerId = bowler.BowlerId, // Include BowlerId in the result
                                 BowlerName = $"{bowler.BowlerFirstName} {bowler.BowlerMiddleInit} {bowler.BowlerLastName}",
                                 TeamName = bt != null ? bt.TeamName : string.Empty,
                                 Address = bowler.BowlerAddress,
                                 City = bowler.BowlerCity,
                                 State = bowler.BowlerState,
                                 Zip = bowler.BowlerZip,
                                 PhoneNumber = bowler.BowlerPhoneNumber
                             };

            return bowlerData.ToArray();
        }
    }
}
