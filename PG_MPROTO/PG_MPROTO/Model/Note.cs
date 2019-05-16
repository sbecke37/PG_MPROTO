using AppServiceHelpers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PG_MPROTO.Model
{
    public class Message : EntityData
    {


        public string Id { get; set; }

        public string Sender { get; set; }

        public string Messagetext { get; set; }

        public string UserImageUrl { get; set; }
    }
}
