using AutoMapper;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public static class Bootstrapper
    {
        public static Container CurrentContainer { get; set; }        

        public static void Init(ILifecycle serviceLifecycle, string connectionString)
        {
            try
            {
                var mapperConfig = new AutoMapperConfig();
                var config = mapperConfig.CreateConfiguration();
                var mapper = config.CreateMapper();
                            
                CurrentContainer = new Container(x =>
                {
                    x.For<IMapper>().Singleton().Use(() => mapper);
                    x.AddRegistry(new RepositoryRegistry(serviceLifecycle, connectionString));
                    x.AddRegistry(new ServiceRegistry(serviceLifecycle));
                });
            }
            catch (Exception ex)
            {
                try
                {
                }
                catch (Exception) { }
                throw;
            }
        }

        public static T Resolve<T>() where T : class
        {
            return (T)CurrentContainer.TryGetInstance(typeof(T));
        }
    }
}
