﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 99999.99)]
        public decimal Amount { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}