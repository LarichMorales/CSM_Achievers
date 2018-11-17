using System;

namespace CSM_Achievers
{
    public interface IServiceCollection
    {
        void Configure<T>(Func<object, object> p);
        void AddDbContext<T>(Func<object, object> p);
        void AddScoped<T1, T2>();
        void AddAuthorization(Func<object, object> p);
        void AddSingleton<T1, T2>();
        void AddSession(Func<object, object> p);
        object AddAuthentication(Func<object, object> p);
        object AddMvc();
    }
}