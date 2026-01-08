namespace EFCore.WebAPI.Model
{
    public class HeroiBatalha
    {
        public int HeroId { get; set; }
        public int BatalhaId { get; set; }
        public Heroi Heroi { get; set; }
        public Batalha Batalha { get; set; }


    }
}
