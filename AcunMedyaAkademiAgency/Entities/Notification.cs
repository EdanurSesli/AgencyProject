using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public String NameSurname { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
    }
}