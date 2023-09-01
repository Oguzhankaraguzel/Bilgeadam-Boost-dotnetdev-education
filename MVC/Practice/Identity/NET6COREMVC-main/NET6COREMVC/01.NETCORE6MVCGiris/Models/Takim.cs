namespace _01.NETCORE6MVCGiris.Models
{
    public class Takim
    {
        public string TakimIsmi { get; set; }
        public int KurulusYili { get; set; }
        public Takim()
        {

        }
        public Takim(string takimIsmi, int kurulusYili)
        {
            TakimIsmi = takimIsmi;
            KurulusYili = kurulusYili;
        }
    }
}
