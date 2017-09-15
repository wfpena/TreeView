using AutoMapper;
using SimpleTaskSystem.Nodes;
using SimpleTaskSystem.Nodes.Dto;
using System.Collections.Generic;

namespace SimpleTaskSystem
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Node, NodeDto>()
                .ForMember(dest => dest.ChildNodes, opt => opt.MapFrom(
                               src => src.ChildNodes != null ? src.ChildNodes : null));
            mapper.CreateMap<NodeDto, Node>();
        }
    }
}
