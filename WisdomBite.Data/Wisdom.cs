using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WisdomBite.Data
{
    public enum Genre { Proverb,Quote,Insight,Musing,Video}
    public class Wisdom
    {
        [Key]
        public int WisdomId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public Genre WisdomGenre { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
