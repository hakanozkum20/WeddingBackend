using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : BaseEntity , IEntity
    {
        public string CompanyName { get; set; } 
        public string CustomerName { get; set; } 
        public string CategoryId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public string Capacity { get; set; }

    }
}
