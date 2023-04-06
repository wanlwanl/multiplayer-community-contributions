using Microsoft.AspNetCore.Mvc.Controllers;
using NegotiateServer.Controllers;
using System.Reflection;

namespace NegotiateServer
{
    public class NegotiateControllerFeatureProvider : ControllerFeatureProvider
    {
        protected override bool IsController(TypeInfo typeInfo)
        {
            var controller = !typeInfo.IsAbstract && typeof(NegotiateController).IsAssignableFrom(typeInfo);
            return controller || base.IsController(typeInfo);
        }
    }
}