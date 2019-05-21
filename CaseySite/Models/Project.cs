using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaseySite.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Summary { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string Github { get; set; }
    }
}