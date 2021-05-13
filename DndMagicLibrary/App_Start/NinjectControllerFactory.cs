using DndMagicLibrary.Data.Api;
using Ninject;
using System;
using System.Net.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DndMagicLibrary.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernel.Bind<HttpClient>().To<HttpClient>();
            ninjectKernel.Bind<IApiHelper>().To<ApiHelper>();
        }
    }
}