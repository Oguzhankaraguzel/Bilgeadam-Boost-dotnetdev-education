

using WebApiCRUD.Model;

namespace WebApiCRUD.Dto
{
    public class BookCreateDTO
    {
        public BookCreateDTO()
        {
            kitapTurleri = new List<string>();
        }
        public string KitapAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public int YazarId { get; set; }
        public List<string> kitapTurleri { get; set; } 
    }
}
