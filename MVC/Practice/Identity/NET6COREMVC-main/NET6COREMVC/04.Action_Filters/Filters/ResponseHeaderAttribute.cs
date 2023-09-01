using Microsoft.AspNetCore.Mvc.Filters;

namespace _04.Action_Filters.Filters
{
    public class ResponseHeaderAttribute : ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        //public ResponseHeaderAttribute(string name, string value) =>
        //(_name, _value) = (name, value);

        /*public ResponseHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }*/
        public ResponseHeaderAttribute(string name, string value) =>
            (_name, _value) = (name, value);


        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.HttpContext.Response.Headers.ContainsKey(_name))
            {
                context.HttpContext.Response.Headers.Remove(_name);
            }
            context.HttpContext.Response.Headers.Add(_name, _value);


            base.OnResultExecuting(context);
        }
    }
}
