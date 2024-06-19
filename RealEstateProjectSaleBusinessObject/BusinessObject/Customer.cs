using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int IdentityCardNumber { get; set; }
        public string Nationality { get; set; }
        public int Taxcode { get; set; }
        public string BankName { get; set; }
        public int BankNumber { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }


    }
}
