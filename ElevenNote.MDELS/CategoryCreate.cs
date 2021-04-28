using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.MDELS
{
    public class CategoryCreate
    {
        [MinLength(2, ErrorMessage = "Please enter at least 2 charcters.")]
        [MaxLength(100, ErrorMessage = "There are too many chracters in this field.")]

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        //data does everything. Model does just what you have to do everything. Data layer, the key. The data base numbers it.
    }
}
