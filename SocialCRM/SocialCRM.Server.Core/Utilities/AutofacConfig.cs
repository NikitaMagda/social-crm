﻿using Autofac;
using SocialCRM.Server.Core.Interfaces;
using SocialCRM.Server.Core.Services;
using SocialCRM.Server.DataAccess;
using SocialCRM.Server.DataAccess.UnitsOfWork;

namespace SocialCRM.Server.Core.Utilities
{
    public class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder)
        {
            builder.Register(c => new ApplicationDbContext("DefaultContext"))
                .InstancePerRequest();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>();

            builder.RegisterType<UserManagerFactory>()
                .As<IUserManagerFactory>();
            builder.RegisterType<UserService>()
                .As<IUserService>();
            builder.RegisterType<RolesService>()
                .As<IRolesService>();
            builder.RegisterType<UserAccountService>()
                .As<IUserAccountService>();

            builder.RegisterType<ClientService>()
                .As<IClientService>();
        }
    }
}