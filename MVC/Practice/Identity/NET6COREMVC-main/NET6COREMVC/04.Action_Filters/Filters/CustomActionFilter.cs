using Microsoft.AspNetCore.Mvc.Filters;

namespace _04.Action_Filters.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter, IOrderedFilter, IResultFilter
    {
        private readonly string _kaynak;
        public int Order { get; set; }

        public CustomActionFilter(string kaynak = "default", int order = 0)
        {
            _kaynak = kaynak;
            Order = order;
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {

            //Console.WriteLine("OnActionExecuted");
            Console.WriteLine(_kaynak + " Action çalıştıktan sonra çalışan metot");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

            try
            {
                if (!context.HttpContext.Request.Query.ContainsKey("fullname"))
                {
                    string isim = context.HttpContext.Request.Query["isim"];
                    string soyIsim = context.HttpContext.Request.Query["soyisim"];
                    
                    context.ActionArguments["fullname"] = (string.IsNullOrEmpty(isim) ? "isim yok" : isim) + " " + (string.IsNullOrEmpty(soyIsim) ? "soy isim yok" : soyIsim);
                }


                var bilgi = context.ActionArguments["bilgi"];
                if (bilgi is not null)
                {
                    if (bilgi.ToString().Length < 5)
                    {
                        context.ActionArguments["bilgi"] = "Bilgi minimum 5 karakter olmalıdır!";
                    }
                }
            }
            catch (KeyNotFoundException knfe)
            {

            }
            finally
            {
                //Console.WriteLine("OnActionExecuting");
                Console.WriteLine(_kaynak + " Action çalışmadan önce çalışan metot");
            }

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

            Console.WriteLine(_kaynak + " Result çalışmadan önce çalışan metot");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine(_kaynak + " Result çalıktan sonra çalışan metot");
        }
    }
}
