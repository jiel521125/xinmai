using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace XinMai.Common.Pay
{
    public static class XinMaiPayModule
    { 
        public static IServiceCollection AddPay(this IServiceCollection services)
        {
            //支付宝多租户
            services.AddScoped<Ali.IPayService, Ali.PayService>();
            //支付宝参数映射
            services.AddAutoMapper(typeof(Ali.PayProfile));
            return services;

        }
    }
}
