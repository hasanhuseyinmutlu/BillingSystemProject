using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Apartment : IEntity
    {
        public int Id { get; set; }

        public string Block { get; set; }

        public string Type { get; set; }

        public bool IsOccupied { get; set; }

        public int Floor { get; set; }

        public int ApartmentNumber { get; set; }

        public string OwnerOrTenant { get; set; }

        public int CustomerId { get; set; }


    }
}
