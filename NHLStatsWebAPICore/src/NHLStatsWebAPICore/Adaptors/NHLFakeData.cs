using NhlStatsDtos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace NHLStatsWebAPICore.Controllers
{
    public class NHLFakeData : INHLStatsDatabase
    {
        Dictionary<int, NhlGameDto> m_Games = new Dictionary<int, NhlGameDto>();

        public NHLFakeData()
        {
            NhlGameDto b = new NhlGameDto();
            b.awayScore = 3;
            b.awayShots = 30;
            b.awayTeamCity = "AWAYCITY";
            b.awayTeamName = "AWAYNAME";
            b.gameId = 1;
            b.homeScore = 4;
            b.homeShots = 40;
            b.homeTeamCity = "HOMECITY";
            b.homeTeamName = "HOMENAME";
            b.startTime = DateTime.Now;

            m_Games.Add(b.gameId, b);
        }

        public bool AddGame(NhlGameDto item)
        {
            m_Games.Add(item.gameId, item);
            return true;
        }

        public IEnumerable<NhlGameDto> GetAllGames()
        {
            return m_Games.Values;
        }

        public NhlGameDto GetGame(int id)
        {
            NhlGameDto game = null;
            if(m_Games.TryGetValue(id, out game))
            {
                return game;
            }
            return game;
        }

        public bool RemoveGame(int id)
        {
            return m_Games.Remove(id);
        }

        public bool UpdateGame(int id, NhlGameDto item)
        {
            m_Games[id] = item;
            return true;
        }
    }
}