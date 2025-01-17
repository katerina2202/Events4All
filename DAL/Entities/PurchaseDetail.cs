﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL.Entities
{ 

    public class PurchaseDetail
    {

        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 99999.99)]
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        [Key, Column(Order = 0)]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        [Key, Column(Order = 1)]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public virtual ICollection<string> TicketCodes { get; set; }

        
    }
}