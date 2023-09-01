namespace _10.Identity.Models
{
    public static class Lang
    {
        public static string GetErrorMessage(string lang)
        {
            string errorMessage = "English Error Message";
            if(lang == "tr")
            {
                errorMessage = "Türkçe Hata Mesajı";
            }
            return errorMessage;
        }
    }
}
