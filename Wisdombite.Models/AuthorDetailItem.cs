using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdombite.Models
{
    public class AuthorDetailItem
    {
        [Required]
        public string Name { get; set; }
        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}
