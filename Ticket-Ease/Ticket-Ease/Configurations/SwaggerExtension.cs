using microsoft.openapi.models;

namespace ticket_ease.configurations
{
    public static class swaggerextension
    {
        public static void addswagger(this iservicecollection services)
        {
            services.addswaggergen(config =>
            {
                config.swaggerdoc("v1", new openapiinfo
                {
                    title = "ticket ease",
                    version = "v1",
                    description = "ticket-ease is a web-based application that streamlines and optimizes the management of task projects"
                });
                config.addsecuritydefinition("bearer", new openapisecurityscheme
                {
                    in = parameterlocation.header,
                    description = "insert token",
                    name = "authorization",
                    type = securityschemetype.http,
                    bearerformat = "jwt",
                    scheme = "bearer"
                });
                config.addsecurityrequirement(new openapisecurityrequirement
                {
                    {
                        new openapisecurityscheme
                        {
                            reference = new openapireference
                            {
                                type = referencetype.securityscheme,
                                id = "bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
        }
    }
}