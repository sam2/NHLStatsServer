using NHLStatsModel;

namespace NhlStatsModel.Events
{
    public class FaceoffEvent : NHLEvent
    {
        public NHLPlayer Winner { get; set; }
        public NHLPlayer Loser { get; set; }    
    }
}