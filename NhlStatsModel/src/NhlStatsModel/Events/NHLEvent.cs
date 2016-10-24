using NHLStatsModel;
using System.Collections.Generic;

namespace NhlStatsModel.Events
{
    public class NHLEvent
    {
        public NHLGameTime GameTime { get; set; }
        public string Strength { get; set; }
        public string Team { get; set; }
        public List<int> AwayOnIce;
        public List<int> HomeOnIce;
        public EZone Zone;
    }

    public enum EZone
    {
        Offsensive,
        Defensive,
        Neutral,
        Unknown
    }
}