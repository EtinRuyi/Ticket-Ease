using Microsoft.AspNetCore.Identity;
using TicketEase.Domain.Entities;
using TicketEase.Persistence.Context;

namespace TicketEase.Configurations
{
	public static class IdentityServiceExtension
	{
		public static void IdentityConfiguration(this IServiceCollection services)
		{
			var builder = services.AddIdentity<AppUser, IdentityRole>(options =>
			{
				options.User.RequireUniqueEmail = true;
				options.SignIn.RequireConfirmedEmail = false;
				options.Password.RequireDigit = false; 
				options.Password.RequireNonAlphanumeric = false; 
				options.Password.RequireUppercase = false; 
				options.Password.RequireLowercase = true;
				options.Password.RequiredLength = 6;
			});
		   
			builder.AddEntityFrameworkStores<TicketEaseDbContext>().AddDefaultTokenProviders();

		}
	}
}