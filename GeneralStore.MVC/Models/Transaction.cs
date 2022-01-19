using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {   
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int TransactionId { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}