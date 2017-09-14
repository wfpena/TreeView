﻿using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace TreeView
{
    /// <summary>
    /// 'Web API layer module' for this project.
    /// </summary>
    [DependsOn(typeof(AbpWebApiModule), typeof(TreeViewApplicationModule))]
    public class TreeViewWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //Creating dynamic Web Api Controllers for application services.
            //Thus, 'web api layer' is created automatically by ABP.

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(Assembly.GetAssembly(typeof (TreeViewApplicationModule)), "tasksystem")
                .Build();
        }
    }
}
