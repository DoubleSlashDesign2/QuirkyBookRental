﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuirkyBookRental.Models
{
    public class MembershipType
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public Byte SignUpFee { get; set; }
        [DisplayName("Rental Rate")]
        [Required]
        public Byte ChargeRateOneMonth { get; set; }
        [Required]
        public Byte ChargeRateSixMonths { get; set; }

    }
}