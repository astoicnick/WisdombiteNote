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
    public class WisdomCreateItem
    {
        [Required]
        [MinLength(15, ErrorMessage = "The content must be at least 15 characters")]
        [MaxLength(120,ErrorMessage = "The content must be less than 120 characters")]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public Genre WisdomGenre { get; set; }
        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}
