
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PG_MPROTO.Model
{
   // public event PropertyChangedEventHandler PropertyChanged;
    public class Message 
    {


        public string id { get; set; }

        public string Sender { get; set; }

        public string Messagetext { get; set; }

        public string UserImageUrl { get; set; }

       
    }

    //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}
}
