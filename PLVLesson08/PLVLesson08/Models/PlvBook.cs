using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLVLesson08.Models
{
    public class PlvBook
    {
        [Key]
        public int PlvBookId { get; set; }
        public string PlvTitle { get; set; }
        public string PlvAuthor { get; set; }
        public int Plvyear { get; set; }
        public string PlvPublisher { get; set; }
        public string PlvPicture { get; set; }
        public string PlvCategoryId { get; set; }
        public virtual PlvCategory PlvCategory { get; set; }
    }
}