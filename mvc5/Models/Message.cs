using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class Message
    {
        public int Id { get; set; }
        //fk
        public int SenderId { get; set; }
        //fk
        public int ReceiverId { get; set; }

        public string Body { get; set; }
        public DateTime DateCreated { get; set; }

        //nav prop based on fk
        [ForeignKey("SenderId")]
        public virtual User Sender { get; set; }
        
        [ForeignKey("ReceiverId")]
        public virtual User Receiver { get; set; }
    }
}