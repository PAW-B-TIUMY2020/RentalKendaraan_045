using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_045.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }
        [Required(ErrorMessage = "Id jenis kendaraan wajib diisi!")]
        public int IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "jenis kendaraan wajib diisi!")]
        public string NamaJenisKendaraan { get; set; }

        public ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
