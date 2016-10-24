using NHLStatsModel;

namespace NhlStatsModel.Events
{
    public class BlockedShotEvent : ShotEvent
    {
        public NHLPlayer Blocker { get; set; }
    }
}