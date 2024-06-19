using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class Properties
    {
        public Guid ProertiesID { get; set; }
        public int Floor {  get; set; }
        public double SizeArea { get; set; }
        public int BedRoom {  get; set; }
        public int BathRoom { get; set;}
        public int LivingRoom { get; set; }
        public double Price { get; set; }
        public string View { get; set; }
        public string Image { get; set; }

    }
}
