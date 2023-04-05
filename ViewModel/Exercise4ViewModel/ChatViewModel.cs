
using Chapter8.Model;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter8.ViewModel.Exercise4ViewModel.ViewModelChat
{
    public class ChatViewModel
    {
        public ObservableCollection<ChatModel> Chats { get; set; }
        public ObservableCollection<ChatModel> ChatStories { get; set; }

        public ChatViewModel()
        {
            ChatDetails();
            StoryDetails();
        }


        public void ChatDetails()
        {
            Chats = new ObservableCollection<ChatModel>
            {
                new ChatModel()
                {
                    Name="Tony Stark",
                    Description="Hello Sir, Can we meet Tommorrow",
                    ImageSource="tony",
                    UnReadMsg=4,
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Thor",
                    Description="Hey How's going the day",
                    ImageSource="thor",
                    UnReadMsg=1,
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Hardik Pandya",
                    Description="Hello sir can we meet tommorrow?",
                    ImageSource="hardik",
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Rohit Sharma",
                    Description="Happy Birthday Sir",
                    ImageSource="rohit",
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Tylor Swift",
                    Description="Hey How's going the day",
                    ImageSource="tylor",
                    UnReadMsg=5,
                    IsStoryPost=true
                },

                new ChatModel()
                {
                    Name="Elon Musk",
                    Description="Ceo of twitter",
                    ImageSource="elon",
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Black Panther",
                    Description="Wakanda Forever",
                    ImageSource="panther",
                    UnReadMsg=2,
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Narendra Modi",
                    Description="Prime Minister",
                    ImageSource="modi",
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Virat Kohli",
                    Description="Hey How's going the day",
                    ImageSource="virat",
                    IsStoryPost=true
                },
            };


            foreach(var item in Chats)
            {
                if(item.UnReadMsg > 0)
                {
                    item.IsRead = false;
                }
                else
                {
                    item.IsRead = true;
                }
            }
        }


        public void StoryDetails()
        {
            ChatStories = Chats.Where(x => x.IsStoryPost == true).ToObservableCollection();
        }
 

    }
}
