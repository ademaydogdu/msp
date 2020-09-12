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
    }
}
