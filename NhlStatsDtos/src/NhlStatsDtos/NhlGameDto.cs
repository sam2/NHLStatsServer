using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhlStatsDtos
{
    public class NhlGameDto
    {
        public string awayTeamCity { get; set; }
        public string awayTeamName { get; set; }

        public string homeTeamName { get; set; }
        public string homeTeamCity { get; set; }

        public int homeScore { get; set; }
        public int awayScore { get; set; }

        public int homeShots { get; set; }
        public int awayShots { get; set; }

        public int gameId { get; set; }

        public DateTime startTime { get; set; }

    }
}
