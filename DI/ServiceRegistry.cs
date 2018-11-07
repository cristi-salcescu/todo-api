using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry(ILifecycle lifecycle)
        {
            Scan(x =>
            {
                x.Assembly("Services");
                x.Include(t => !t.IsAbstract && t.Name.EndsWith("Service"));
                x.WithDefaultConventions().OnAddedPluginTypes(c => c.LifecycleIs(lifecycle));
            });            
        }
    }
}
