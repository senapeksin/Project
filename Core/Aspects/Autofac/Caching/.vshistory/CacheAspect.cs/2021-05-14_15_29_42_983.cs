using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection; 

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        /*
         CacheAspect: bir tane ctor 'u var. Default değer olarak 60 verdik. Demekki süre vermezsek bu veri 60 dk boyunca cache de duracak
        daha sonra cache'den ucacak, bellekten, otomatik olarak.
         CacheAspect'te bir Aspect olduğu için injection burada yapamayız.Bu nedenle ServiceTool kullanarak hangi Cache Manager kullandığımı
        belirtiyorum.Redis kullanırsam da yapacağım tek sey Redis klasörü olusturup , CoreModul de bunu belirtmek.(buraya dokunmuyorum)
         */
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60)
        {
            _duration = duration; //duration set edildi.
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            if (_cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }
            invocation.Proceed();
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
