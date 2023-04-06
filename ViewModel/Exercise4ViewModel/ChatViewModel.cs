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
                    LastSeen="2:45 PM",
                    UnReadMsg=4,
                    IsOnline=true,
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Thor",
                    Description="Hey How's going the day",
                    ImageSource="thor",
                    UnReadMsg=1,
                    LastSeen="2:45 PM",
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Hardik Pandya",
                    Description="Hello sir can we meet tommorrow?",
                    ImageSource="hardik",
                    LastSeen="2:36 PM",
                    IsOnline=true,
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Rohit Sharma",
                    Description="Happy Birthday Sir",
                    ImageSource="rohit",
                    LastSeen="1:58 PM",
                    IsOnline=true,
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Tylor Swift",
                    Description="Hey How's going the day",
                    ImageSource="tylor",
                    UnReadMsg=5,
                    LastSeen="2:45 PM",
                    IsStoryPost=true
                },

                new ChatModel()
                {
                    Name="Elon Musk",
                    Description="Ceo of twitter",
                    ImageSource="elon",
                    LastSeen="3:45 AM",
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Black Panther",
                    Description="Wakanda Forever",
                    ImageSource="panther",
                    UnReadMsg=2,
                    LastSeen="2:40 AM",
                    IsStoryPost=true
                },
                new ChatModel()
                {
                    Name="Narendra Modi",
                    Description="Prime Minister",
                    ImageSource="modi",
                    LastSeen="2:45 AM",
                    IsStoryPost=false
                },
                new ChatModel()
                {
                    Name="Virat Kohli",
                    Description="Hey How's going the day",
                    ImageSource="virat",
                    LastSeen="12:05 PM",
                    IsStoryPost=true
                },
            };


            foreach(var item in Chats)
            {
                if(item.UnReadMsg > 0)
                {
                    item.IsRead = true;
                }
                else
                {
                    item.IsRead = false;
                }
            }

            foreach(var item in Chats)
            {
                if (item.IsRead == true)
                {
                    item.IsLastSeen = false;
                }
                else
                {
                    item.IsLastSeen = true;
                }
            }
        }


        public void StoryDetails()
        {
            ChatStories = Chats.Where(x => x.IsStoryPost == true).ToObservableCollection();
        }
 

    }
}
