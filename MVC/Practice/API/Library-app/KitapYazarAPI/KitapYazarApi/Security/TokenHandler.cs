using KitapYazarApi.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KitapYazarApi.Security
{
    public static class TokenHandler
    {

        public static JwtSecurityToken GetToken(IConfiguration _configuration,User user,Token token2)
        {
            
            var payload = new List<Claim>
                    {
                        new Claim ("username", user.UserName),
                        new Claim("tokenID",Guid.NewGuid().ToString())
                    };
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT")["Secret"]));
            var token = new JwtSecurityToken(
            issuer: _configuration["JWT:ValidIssuer"],
            audience: _configuration["JWT:ValidAudience"],
            claims: payload,
            //notBefore: DateTime.UtcNow.AddMinutes(5),//5 dk sonra token aktif olacaktır!
            //Belirlenen süre sonunda token geçersiz olacaktır!
            expires: token2.Expiration,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
            );
           
            return token;
        }
    }
}
