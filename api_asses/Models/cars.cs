using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace api_asses.Models
{
    public class cars
    {
        [Key]
        public int id { get; set; }
        public string CountryName { get; set; }
        public string Capital { get; set; }
    }
}