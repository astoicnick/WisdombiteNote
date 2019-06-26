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
    public class WisdomListItem
    {
        [Required]
        public string Content { get; set; }
        [Required]
        public Genre WisdomGenre { get; set; }
        [Required]
        public AuthorListItem Author { get; set; }
    }
}
