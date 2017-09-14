﻿using System.Reflection;
using Abp.Modules;

namespace TreeView
{
    /// <summary>
    /// 'Core module' for this project.
    /// </summary>
    public class TreeViewCoreModule : AbpModule
    {
        public override void Initialize()
        {
            //This code is used to register classes to dependency injection system for this assembly using conventions.
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
