//using Microsoft.OpenApi.Models;

//namespace Ticket_Ease.Configurations
//{
//    public static class SwaggerExtension
//    {
//        public static void AddSwagger(this IServiceCollection services)
//        {
//            services.AddSwaggerGen(config =>
//            {
//                config.SwaggerDoc("v1", new OpenApiInfo
//                {
//                    Title = "Ticket Ease",
//                    Version = "v1",
//                    Description = "Ticket-Ease is a web-based application that streamlines and optimizes the management of task projects"
//                });
//                config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//                {
//                    In = ParameterLocation.Header,
//                    Description = "Insert Token",
//                    Name = "Authorization",
//                    Type = SecuritySchemeType.Http,
//                    BearerFormat = "Jwt",
//                    Scheme = "Bearer"
//                });
//                config.AddSecurityRequirement(new OpenApiSecurityRequirement
//                {
//                    {
//                        new OpenApiSecurityScheme
//                        {
//                            Reference = new OpenApiReference
//                            {
//                                Type = ReferenceType.SecurityScheme,
//                                Id = "Bearer"
//                            }
//                        },
//                        new string[] {}
//                    }
//                });
//            });
//        }
//    }
//}

namespace TicketEase.Mapper
{


    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProjectRequestDto, Project>()
               .ForMember(dest => dest.Id, opt => opt.Ignore())
               .ForMember(dest => dest.BoardId, opt => opt.Ignore());

            CreateMap<UpdateProjectRequestDto, Project>();

            CreateMap<Project, ProjectReponseDto>().ReverseMap();
            CreateMap<Manager, EditManagerDto>().ReverseMap();
            CreateMap<BoardRequestDto, Board>();
            CreateMap<Board, BoardResponseDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<UpdateTicketDto, Ticket>();
            CreateMap<AppUser, AppUserDto>();
            CreateMap<PageResult<IEnumerable<AppUser>>, PageResult<IEnumerable<AppUserDto>>>();
            CreateMap<UpdateUserDto, AppUser>();
        }
    }
}

