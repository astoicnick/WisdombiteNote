using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomBite.Data;

namespace Wisdombite.Models
{
    public class WisdomDetailItem
    {
        [Required]
        public string Content { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public Genre WisdomGenre { get; set; }
        [Display(Name = "Created At")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public AuthorDetailItem Author { get; set; }
    }
}
