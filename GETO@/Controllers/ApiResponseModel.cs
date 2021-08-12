using GETO_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Controllers
{
    public class ApiResponseModelPlasma
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public List<PlasmaDonor> DonorList { get; set; }
    }
    public class ApiResponseModelO2
    {
        public bool success { get; set; }
        public string msg { get; set; }
        public List<OxyDonator> DonorList { get; set; }
    }
    public class ApiResponseModeAddlO2
    {
        public bool success { get; set; }
        public string msg { get; set; }
       
    }
    public class MenuItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public IEnumerable<MenuItems> ChildMenu { get; set; }
    }
}
