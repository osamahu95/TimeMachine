namespace TImeMachine.Models
{
    public class EventSchedule
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime UtcDateTime { get; set; }
        public string  OriginalTimeZone { get; set; }
    }
}
