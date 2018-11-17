using System;

namespace CSM_Achievers
{
    public interface IApplicationBuilder
    {
        object ApplicationServices { get; }

        void UseExceptionHandler(string v);
        void UseAuthentication();
        void UseHttpsRedirection();
        void UseSession();
        void UseStaticFiles();
        void UseCookiePolicy();
        void UseMvc(Func<object, object> p);
        void UseHsts();
        void UseDeveloperExceptionPage();
    }
}