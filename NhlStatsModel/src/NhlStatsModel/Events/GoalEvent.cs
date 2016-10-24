using NHLStatsModel;

namespace NhlStatsModel.Events
{
    public class GoalEvent : ShotOnGoalEvent
    {
        public NHLPlayer Assist1 { get; set; }
        public NHLPlayer Assist2 { get; set; }
    }
}