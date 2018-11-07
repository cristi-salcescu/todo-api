using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry(ILifecycle lifecycle, string connectionString)
        {
            Scan(x =>
            {
                x.Assembly("Repositories");
                x.Include(t => !t.IsAbstract && (t.Name.EndsWith("Repository") || t.Name.EndsWith("UnitOfWork")));
                x.WithDefaultConventions().OnAddedPluginTypes(c => c.LifecycleIs(lifecycle));
            });            
        }
    }
}
