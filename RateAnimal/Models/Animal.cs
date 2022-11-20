using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RateAnimal.Models
{
    public class Animal : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }
        [StringLength(100)]
        public string ImgUrl { get; set; }

        public Category Category { get; set; }
        public Size Size { get; set; }
    }
}
