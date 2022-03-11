namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string ClientDate { get; set; }
    public string ClientNotes { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}