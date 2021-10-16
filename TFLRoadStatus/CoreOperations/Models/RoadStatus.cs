
namespace TFLRoadStatus.CoreOperations.Models
{
    /// <summary>
    /// Represent the Road Status Information
    /// </summary>
    public class RoadStatus
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string StatusSeverity { get; set; }
        public string StatusSeverityDescription { get; set; }
        public bool HttpsStatus { get; set; }
    }
}
