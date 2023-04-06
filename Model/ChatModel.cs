
namespace Chapter8.Model
{
     public class ChatModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public int UnReadMsg { get; set; }
        public bool IsRead { get; set; }
        public bool IsStoryPost { get; set; } 
        public bool IsOnline { get; set; }
    }
}
