namespace KitapYazarApi.Services
{
    public class UserService:IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetMyName()
        {
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            return userName;
        }
    }
}
