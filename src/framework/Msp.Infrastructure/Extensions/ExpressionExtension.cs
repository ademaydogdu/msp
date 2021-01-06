using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure.Extensions
{
    public static class ExpressionExtension
    {
        public static List<object> GetParamsFromExpression<T>(this Expression<T> expression) where T : class
        {
            var args = from arg in ((MethodCallExpression)expression.Body).Arguments
                       let argAsObj = Expression.Convert(arg, typeof(object))
                       select Expression.Lambda<Func<object>>(argAsObj, null)
                                        .Compile()();
            var list = args.ToList();

            return list;

        }

        public static object GetValue<S>(this S source, string name) where S : class
        {
            //we will see what happend when we use it (OUZ)
            object value = default;
            Type reservation = source.GetType();
            var properties = reservation.GetProperty(name);
            if (properties != null)
            {
                value = properties.GetValue(source, null);
                if (value == null)
                {
                    if (value is decimal)
                    {
                        value = 0;
                    }
                    if (value is string)
                    {
                        value = "";
                    }
                    if (value is int)
                    {
                        value = 0;
                    }
                    if (value is double)
                    {
                        value = 0;
                    }
                }
            }
            return value;

        }

    }
}
