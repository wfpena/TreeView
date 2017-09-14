using Abp.Application.Services.Dto;
using System.Collections.Generic;


namespace TreeView.Nodes.Dto
{
    public class NodeDto : EntityDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<NodeDto> ChildNodes { get; set; }
    }
}
