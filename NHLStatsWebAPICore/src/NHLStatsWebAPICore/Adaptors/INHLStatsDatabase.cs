using System.Linq;

using System.Collections.Generic;
using NhlStatsDtos;

namespace NHLStatsWebAPICore.Controllers
{
    interface INHLStatsDatabase
    {
         IEnumerable<NhlGameDto> GetAllGames();

         NhlGameDto GetGame(int id);
         
         bool AddGame(NhlGameDto item);
      
         bool RemoveGame(int id);
      
         bool UpdateGame(int id, NhlGameDto item);     
    }
}
