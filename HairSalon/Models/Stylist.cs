using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    // [Required(ErrorMessage = "Stylist Name can't be blank!")]
    public string StylistName { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}