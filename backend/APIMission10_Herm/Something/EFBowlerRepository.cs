namespace APIMission10_Herm.Something
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        
        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;
    }
}
