using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class ProjectDetail
    {
        public int ProjectDetailId { get; set; }
        public String ProjectName { get; set; }
        public String Title { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }
    }
}