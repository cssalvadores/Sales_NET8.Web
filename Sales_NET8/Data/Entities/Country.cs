﻿using System.ComponentModel.DataAnnotations;

namespace Sales_NET8.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="País")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no maximo {1} caractéres.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]

        public string? Name { get; set; }
    }
}
