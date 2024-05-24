using CleanArch.Infra.IoC;

namespace CleanArch.Api.Middlewares
{
    public static class RegisterServices
    {
        public static void Register(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}
