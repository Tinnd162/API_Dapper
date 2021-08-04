using azicloud.wiki.bo.Category;
using azicloud.wiki.bo.Data;
using azicloud.wiki.bo.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace azicloud.wiki.bo.Extensions
{
    public static class WikiServiceExtention
    {
        public static IServiceCollection AddWikiServices(this IServiceCollection services, string conStr)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(conStr);
            });

            services.AddScoped<IDapperService>(sp => new DapperService(conStr));
            services.AddScoped<Iwiki_category, wiki_category>();
            return services;
        }
    }
}