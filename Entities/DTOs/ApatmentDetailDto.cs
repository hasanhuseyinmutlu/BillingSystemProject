using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ApartmentDetailDto : IDto
    {
        public int CustomerId { get; set; }

        //public int AparmentId { get; set; }

        public string Block { get; set; }

        public string Type { get; set; }

        public int Floor { get; set; }

        public int ApartmentNumber { get; set; }

        public string OwnerOrTenant { get; set; }
        public string Mail { get; set; }
    }
}
