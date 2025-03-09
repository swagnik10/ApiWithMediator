using Microsoft.Extensions.DependencyInjection;
using System;

namespace MediatorPatternApi.Mediators
{
    public class Class
    {

/*        public Task<object?> Send(object request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            return _requestHandlers.GetOrAdd(request.GetType(), delegate (Type requestType)
            {
                Type type = requestType.GetInterfaces().FirstOrDefault((Type i) => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequest<>));
                Type type2;
                if ((object)type == null)
                {
                    type = requestType.GetInterfaces().FirstOrDefault((Type i) => i == typeof(IRequest));
                    if ((object)type == null)
                    {
                        throw new ArgumentException(requestType.Name + " does not implement IRequest", "request");
                    }

                    type2 = typeof(RequestHandlerWrapperImpl<>).MakeGenericType(requestType);
                }
                else
                {
                    Type type3 = type.GetGenericArguments()[0];
                    type2 = typeof(RequestHandlerWrapperImpl<,>).MakeGenericType(requestType, type3);
                }

                return (RequestHandlerBase)(Activator.CreateInstance(type2) ?? throw new InvalidOperationException($"Could not create wrapper for type {requestType}"));
            }).Handle(request, _serviceProvider, cancellationToken);
        }*/

    }
}
