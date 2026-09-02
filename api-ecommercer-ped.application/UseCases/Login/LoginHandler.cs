using api_ecommercer_ped.application.UseCases.Login;
using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace api_ecommercer_ped.application.UseCases.CreateUser
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {

            var resp = new LoginResponse();
            if ((request.User == "dev@martech.com") && (request.Password == "Senha@123"))
            {
                resp.SessionId = Guid.NewGuid();
                resp.Token = GerarToken(request.User);
            } else
            {
                resp.Token = "";
            }

            return resp;
        }

        public string GerarToken(string email)
        {
            string chaveSecreta = "sua_chave_secreta_com_pelo_menos_32_caracteres_123456";
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(chaveSecreta);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Email, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }),
                Expires = DateTime.UtcNow.AddHours(2), 
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


    }
}
