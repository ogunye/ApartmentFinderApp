using System.ComponentModel.DataAnnotations.Schema;

namespace ApartmentFinderApp.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string? ApartmentType { get; set; }
        public double Rent { get; set; }
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public int NumberOfRooms { get; set; }
        public int IsAvailable { get; set; }
    }
}
