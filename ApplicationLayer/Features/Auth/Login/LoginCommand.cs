using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ApplicationLayer.Features.Auth.Login
{
    public sealed record class LoginCommand(string UserNameOrEmail, string Password) : IRequest<Result<LoginCommandResponse>>;

    public sealed record LoginCommandResponse(string Token);

    internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
    {
        public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser? appUser = await userManager.Users.FirstOrDefaultAsync(a => a.UserName == request.UserNameOrEmail || a.Email == request.UserNameOrEmail, cancellationToken);

            if (appUser is null)
                return Result<LoginCommandResponse>.Failure("User not found");

            bool isPasswordCorrect = await userManager.CheckPasswordAsync(appUser, request.Password);

            if (!isPasswordCorrect)
                return Result<LoginCommandResponse>.Failure("Password is wrong");

            return Result<LoginCommandResponse>.Succeed(new LoginCommandResponse("Token"));
        }
    }
}