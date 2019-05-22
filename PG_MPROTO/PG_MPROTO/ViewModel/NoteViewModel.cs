using PG_MPROTO.Model;
using PG_MPROTO.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PG_MPROTO.ViewModel
{

    public class NoteViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Message> _messages;
        //private ObservableCollection<Note1> _note;
        private string _userName;
        private string _textMessage;
        private ICommand _sendMessageCommand;
        private ICommand _delMessageCommand;
        private NoteService _azureDataService = new NoteService();

        public event PropertyChangedEventHandler PropertyChanged;
       // public Note1 Note1 { get; set; }

        //private Message MessageInfo;
        //public Message Meassage
        //{
        //    get { return this.MessageInfo; }
        //    set { this.MessageInfo = value; }


        //}

        public NoteViewModel()
        {
            Messages = new ObservableCollection<Message>();


            //Messages.Add(new Message {Messagetext = "Hello", Sender = "Sender", UserImageUrl = "me_user.png"});

            InitializeMessage();
        }

        private async void InitializeMessage()
        {
            var message = await _azureDataService.GetMessages();

            foreach (var message1 in message)
            {
                Messages.Add(message1);
            }
            
            
        }

        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                OnPropertyChanged("Messages");
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string TextMessage
        {
            get { return _textMessage; }
            set
            {
                _textMessage = value;
                OnPropertyChanged("TextMessage");
            }
        }

        public ICommand SendMessageCommand
        {
            get
            {
                return _sendMessageCommand = _sendMessageCommand ?? new Command(async () =>
                {
                    var msg = new Message
                    {
                        Messagetext = TextMessage,
                        Sender = UserName,
                        UserImageUrl = "me_user.png"
                    };

                    Messages.Add(msg);

                    await _azureDataService.AddMessage(msg);
                });
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
