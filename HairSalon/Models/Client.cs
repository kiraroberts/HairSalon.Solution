using System.ComponentModel.DataAnnotations;
namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public bool NewOrReturning { get; set; }
        public int StylistId { get; set; }
        public virtual Stylist Stylist { get; set; }
    }
}