using GrpcToolkit.Interfaces;
using GrpcToolkit.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using System.Reflection;
using System.Linq;
using GrpcToolkit.Attributes;
using Microsoft.AspNetCore.Builder;
using System;

namespace GrpcToolkit.Extensions
{
    public static class GrpcToolKitExtension
    {
        public static void RegisterGrpcToolkit(this IServiceCollection services)
        {
            services.AddTransient(typeof(IServerTool<>), typeof(ServerTool<>));
            services.AddScoped<IClientTool, ClientTool>();
        }

        public static void MapMessageBrokers(this IEndpointRouteBuilder routeBuilder, params Assembly[] assemblies)
        {
            var types = assemblies.SelectMany(x => x.GetTypes()).Where(x => x.GetCustomAttribute(typeof(GrpcServerAttribute)) != null).ToList();

            foreach (var type in types)
            {
                InvokeMapMessageBrokers(routeBuilder, type);
            }
        }

        private static void InvokeMapMessageBrokers(IEndpointRouteBuilder routeBuilder, Type type)
        {
            var invokable = typeof(GrpcEndpointRouteBuilderExtensions)
                       .GetMethod("MapGrpcService", new Type[] { typeof(IEndpointRouteBuilder) }).MakeGenericMethod(type);

            invokable.Invoke(null, new object[] { routeBuilder });
        }
    }
}
