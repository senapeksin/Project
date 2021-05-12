using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        // IServiceCollection (var olan sisteme) extension yapıcaz.
        //IServiceCollection : Apimizin servis bağımlılıklarını eklediğimiz yada  araya girmesini istediğimiz servisleri eklediğimiz koleksiyon. 
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection,ICoreModule[] modules)
        {
            foreach (var module in modules) //modüllerdeki herbir modül için  modlü yükle
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
