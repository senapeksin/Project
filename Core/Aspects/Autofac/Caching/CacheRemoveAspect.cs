using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{

    /*
     CacheRemoveAspect Ne Zaman Çalışır ?
        Datanız bozulursa, (yeni data eklenir, güncellenir ve silinirse)
        O yüzden bir MAnager'da cache yönetimi yapıyorsanız, o managerda veriyi manipule eden  metodlarına CacheRemoveAspect uygularsın.
     
     */

    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation) //metod başarılı olursa ekle demek .
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
