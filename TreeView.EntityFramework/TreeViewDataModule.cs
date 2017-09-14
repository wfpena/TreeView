using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;

namespace TreeView
{
    [DependsOn(typeof(TreeViewCoreModule), typeof(AbpEntityFrameworkModule))]
    public class TreeViewDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
