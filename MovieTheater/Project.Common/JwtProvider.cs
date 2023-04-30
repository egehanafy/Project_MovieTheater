using Microsoft.IdentityModel.Tokens;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project.Common
{
    public static class JwtProvider
    {
        public static string GenerateJwtToken(AppUser user)
        {
            //Claim
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("b51487ad3be4760cada8cfb4523451c2459f8c398d98ee3657ca4729797195d7"));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expires = DateTime.Now.AddDays(Convert.ToDouble(365));

            var token = new JwtSecurityToken(issuer: "https://localhost:44301", audience: "https://localhost:44301", claims: claims, expires: expires, signingCredentials: credentials);

            var result = new JwtSecurityTokenHandler().WriteToken(token);
            
            return result;
        }
    }
}
