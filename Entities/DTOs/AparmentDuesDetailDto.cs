using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AparmentDuesDetailDto
    {
        public decimal DuesAmount { get; set; }

        public string DuesDate { get; set; }

        public int ApartmentNumber { get; set; }

        public string ApartmentBlock { get; set; }

    }
}
