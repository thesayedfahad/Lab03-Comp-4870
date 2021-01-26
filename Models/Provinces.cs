using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Province.Models{
    public class Provinces {

        [Key]
        public string  ProvinceCode {get; set;}

        public string  ProvinceName {get; set;}


            public List<City> Cities {get; set;}

    }

}