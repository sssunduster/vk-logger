namespace VKLogger.Core.Entities
{
    public class VkStatusAudio
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Url { get; set; }
        public bool IsHq { get; set; }
    }
}
