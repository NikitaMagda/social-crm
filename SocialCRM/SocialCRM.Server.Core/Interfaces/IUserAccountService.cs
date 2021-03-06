﻿using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using SocialCRM.Domain.Entities;
using SocialCRM.Dtos.Models;

namespace SocialCRM.Server.Core.Interfaces
{
    public interface IUserAccountService
    {
        //Task<IdentityResult> ChangePasswordAsync(ChangePasswordDto changePasswordDto);
        Task<ApplicationUser> LogInAsync(LoginDto loginDto);
        Task<IdentityResult> RegisterAsync(RegisterDto registerDto);
    }
}