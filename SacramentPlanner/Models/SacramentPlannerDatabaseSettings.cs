using System;
namespace SacramentPlanner.Models
{
    public class SacramentPlannerDatabaseSettings : ISacramentPlannerDatabaseSettings
    {
        public string AgendaCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISacramentPlannerDatabaseSettings
    {
        string AgendaCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
