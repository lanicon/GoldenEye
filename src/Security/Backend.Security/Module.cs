﻿using GoldenEye.Backend.Security.DataContext;
using GoldenEye.Backend.Security.Model;
using GoldenEye.Shared.Core.Modules;
using GoldenEye.Shared.Core.Modules.Attributes;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: ProjectAssembly]
namespace GoldenEye.Backend.Security
{
    public class Module : ModuleBase
    {
        public override void Load()
        {
            Kernel.Bind<IdentityDbContext<User>>().To<UserDataContext>();
        }
    }
}