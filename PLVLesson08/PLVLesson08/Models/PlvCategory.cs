using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PLVLesson08.Models
{
    public class PlvCategory
    {
        [Key]
        public int PlvCategoryId { get; set; }
        public string PlvCategoryName { get; set; }
        public virtual ICollection<PlvBook> PlvBooks { get; set; }

    }
}