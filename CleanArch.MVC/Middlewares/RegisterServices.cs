using CleanArch.Infra.IoC;

namespace CleanArch.MVC.Middlewares
{
    public static class RegisterServices
    {
        public static void Register(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}
