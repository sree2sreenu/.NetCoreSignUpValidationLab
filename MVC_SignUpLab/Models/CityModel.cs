using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SignUpLab.Models
{
    public class CityModel
    {
        public string  CityCode { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public CountryModel Country { get; set; }

        public List<CityModel> GetCitiNames()
        {
            return new List<CityModel>
            {
                new CityModel{City="Hyderabad",CityCode= "HYD",CountryCode="IND"},
                new CityModel{City="Delhi",CityCode= "DEL",CountryCode="IND"},
                new CityModel{City="Dallas",CityCode= "DAL",CountryCode="USA"},
                new CityModel{City="Washington",CityCode= "WAS",CountryCode="USA"},
                new CityModel{City="Sydney",CityCode= "SYD",CountryCode="AUS"},
                new CityModel{City="Melbourne",CityCode= "MEL",CountryCode="AUS"}
            };
        }

    }
}
