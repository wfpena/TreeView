using Abp.Application.Services;
using SimpleTaskSystem.Nodes.Dto;
using System.Collections.Generic;

namespace SimpleTaskSystem.Nodes
{
    /// <summary>
    /// Defines an application service for <see cref="Task"/> operations.
    /// 
    /// It extends <see cref="IApplicationService"/>.
    /// Thus, ABP enables automatic dependency injection, validation and other benefits for it.
    /// 
    /// Application services works with DTOs (Data Transfer Objects).
    /// Service methods gets and returns DTOs.
    /// </summary>
    public interface INodeAppService : IApplicationService
    {
        List<NodeDto> GetAll(); 
        NodeDto GetNode(NodeDto input);

        void UpdateNode(NodeDto input);
        void DeleteNodes(int id);
        void CreateNode(NodeDto input, int parentId);
        void DeleteAll();
    }
}
