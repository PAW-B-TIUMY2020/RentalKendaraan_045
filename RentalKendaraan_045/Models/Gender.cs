﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        [Required(ErrorMessage = "Data Gender wajib diisi!")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }

    }
}
