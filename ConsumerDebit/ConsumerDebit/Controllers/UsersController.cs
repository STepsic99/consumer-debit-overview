using ConsumerDebit.Dto;
using ConsumerDebit.Model;
using ConsumerDebit.Repository;
using ConsumerDebit.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerDebit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UsersService usersService = new UsersService(new UsersRepository());
        TrafficsService trafficsService = new TrafficsService(new TrafficsRepository());
        private IConfiguration _config;

        public UsersController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            User user = AuthenticateUser(dto.Username, dto.Password);
            if(user==null) return BadRequest("Korisnik ne postoji.");
            var tokenStr = GenerateJSONWebToken(user);
            return Ok(new { token = tokenStr });
        }

        private User AuthenticateUser(string username, string password)
        {
            return usersService.FindUser(username,password);
        }

        private string GenerateJSONWebToken(User userinfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userinfo.Owner),
                new Claim(JwtRegisteredClaimNames.Jti,userinfo.IDUser)
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
                );

            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;
        }

        [Authorize]
        [HttpGet("traffic")]
        public IActionResult GetTraffic()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            String userId = claim[1].Value;
            return Ok(trafficsService.GetAllTrafficForUser(userId));
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetUsername()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claim = identity.Claims.ToList();
            String username = claim[0].Value;
            return Ok(username);
        }
    }
}
