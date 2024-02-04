using CustomIdentity.Models;

namespace CustomIdentity.ViewModels
{
    public class SozlukVM
    {
        public string? Kelime { get; set; }
        public string? Cumle { get; set; }
        public DateTime Tarih { get; set; }
        public List<Sozluk>? EklenmisSozcukler { get; set; }
    }
}
