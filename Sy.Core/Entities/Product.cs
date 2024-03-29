﻿using Sy.Core.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sy.Core.Entities
{
    [Table(name: "Products")]
    public class Product : BaseEntity<Guid>
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [Required,StringLength(100)]
        public string ProductName { get; set; }
        [Range(0, 9999999)]
        public decimal UnitPrice { get; set; }    
        public int CriticStock { get; set; } = 10;

    }
}
