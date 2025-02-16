using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public String NameSurname { get; set; }
        public String Email { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}