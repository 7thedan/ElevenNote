using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.MODELS
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 charcters.")]
        [MaxLength(100, ErrorMessage = "There are too many chracters in this field.")]
        public string Title { get; set; }
        [MaxLength(8000)]
        public string Content { get; set; }
        [Display(Name ="Category Name")]
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
