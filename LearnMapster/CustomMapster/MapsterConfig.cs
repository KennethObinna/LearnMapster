using LearnMapster.Models;
using LearnMapster.Models.DTOs;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LearnMapster.CustomMapster
{
    public static class MapsterConfig
    {
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            TypeAdapterConfig<Person, PersonShortInfoDto>
                .NewConfig()
            
                .Map(dest => dest.FullName, src => $"{src.Title} {src.FirstName} {src.LastName}")
                .Map(dest=>dest.Address,src=>$"{src.Address.Street} {src.Address.City} {src.Address.Country}")
                .Map(dest=>dest.Addresses,src=>src.Address)
                .Fork(config => config.Default.PreserveReference(true));

            TypeAdapterConfig<ParentPoco, ParentPocoDTO>.NewConfig()
                .PreserveReference(true);
             TypeAdapterConfig<ParentPoco, ParentPocoDTO2>.NewConfig()
                .Map(des=>des.Name, src=>src.Name+"Testing")
                .Map(dest=>dest.Children, src=>src.Children)
                .PreserveReference(true);

            TypeAdapterConfig<ChildPoco, ChildPocoDTO>.NewConfig()
                       .PreserveReference(true);
            TypeAdapterConfig<ChildrenChildPoco, ChildrenChildPocoDTO>.NewConfig()
            .PreserveReference(true);
            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}
