using MediatorPatternApi.Handler;

namespace MediatorPatternApi.Mediators
{
/*    public class Mediator : IMediator
    {
        private readonly Dictionary<Type, object> _handlers = new();

        // Register a handler for a request type
        public void Register<TRequest, TResponse>(IUserHandler<TRequest, TResponse> handler)
        {
            _handlers[typeof(TRequest)] = handler;
        }

        // Handle the request and return the response
        public TResponse Send<TRequest, TResponse>(TRequest request)
        {
            if (_handlers.TryGetValue(typeof(TRequest), out var handlerObj))
            {
                var handler = (IUserHandler<TRequest, TResponse>)handlerObj;
                return handler.Handle(request);
            }

            throw new InvalidOperationException($"No handler registered for {typeof(TRequest).Name}");
        }
    }*/
}
