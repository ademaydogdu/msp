using Msp.Infrastructure.Extensions;
using Msp.Service.Http;
using Msp.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Service.Repository
{
    public class Repository
    {

        private HttpService _httpService;
        private bool _localApp = true;
        string ApiUrl;

        public Repository()
        {
            if (!string.IsNullOrEmpty(ApiUrl))
                _httpService = new HttpService(ApiUrl);
        }

        public G Run<T, G>(Expression<Func<T, G>> expression) where T : BaseService where G : class
        {
            var instance = Activator.CreateInstance<T>();
            if (_localApp)
            {
                var action = expression.Compile();
                return action(instance);
            }
            else
            {
                _httpService.SetRouteMap(((MethodCallExpression)expression.Body).Method.Name);
                var parameterList = instance.GetType().GetMethod(((MethodCallExpression)expression.Body).Method.Name).GetParameters().Select(x => x.Name).ToList();
                var objects = expression.GetParamsFromExpression();
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                for (int i = 0; i < parameterList.Count; i++)
                {
                    dictionary.Add(parameterList[i], objects[i]);
                }
                return _httpService.Send<G>(dictionary);
            }
        }

        public void Run<T>(Expression<Action<T>> expression) where T : BaseService
        {
            var instance = Activator.CreateInstance<T>();
            if (_localApp)
            {
                var action = expression.Compile();
                action(instance);
            }
            else
            {
                _httpService.SetRouteMap(((MethodCallExpression)expression.Body).Method.Name);
                var parameterList = instance.GetType().GetMethod(((MethodCallExpression)expression.Body).Method.Name).GetParameters().Select(c => c.Name).ToList();

                var objects = expression.GetParamsFromExpression();
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                for (int i = 0; i < parameterList.Count; i++)
                {
                    dictionary.Add(parameterList[i], objects[i]);
                }
                _httpService.Send<T>(dictionary);
            }
        }



    }
}
