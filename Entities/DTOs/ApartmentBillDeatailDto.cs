using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ApartmentBillDeatailDto : IDto
    {
        public string BillType { get; set; }

        public decimal BillAmount { get; set; }

        public string BillDate { get; set; }

        public int ApartmentNumber { get; set; }

        public string ApartmentBlock { get; set; }
    }
}
