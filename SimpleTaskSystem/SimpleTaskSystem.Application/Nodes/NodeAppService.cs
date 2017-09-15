using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using SimpleTaskSystem.Nodes.Dto;
using System;
using System.Linq;

namespace SimpleTaskSystem.Nodes
{
    public class NodeAppService : ApplicationService, INodeAppService
    {
        
        private readonly INodeRepository _nodeRepository;
        //private readonly IRepository<Person> _personRepository;
        
        public NodeAppService(INodeRepository nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }
        
        public NodeDto GetNode(NodeDto input)
        {
            //Called specific GetAllWithPeople method of task repository.
            //var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

            ////Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            //return new GetTasksOutput
            //       {
            //           Tasks = Mapper.Map<List<TaskDto>>(tasks)
            //       };

            return input;
        }
        
        public void UpdateNode(NodeDto input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var node = _nodeRepository.Get(input.Id);

            node.Title = input.Title;
            node.Description = input.Description;
        }

        public void CreateNode(NodeDto input, int parentId = 0)
        {
            //var node = new Node();
            if(parentId == 0)
            {
                var node = new Node { Description = input.Description, Title = input.Title, ParentId = null, ParentNode = null };
                _nodeRepository.Insert(node);
            }
            else
            {
                var parent = _nodeRepository.Get(parentId);
                var node = new Node { Description = input.Description, Title = input.Title, ParentId = parentId, ParentNode = parent };
                _nodeRepository.Insert(node);
            }
            

            
        }

        public List<NodeDto> GetAll()
        {
            var nodes = _nodeRepository.GetAll().Where(p => p.ParentId == null).ToList();

            //return new NodeDto({Id = nodes.Id,  });
            return Mapper.Map <List<NodeDto>> (nodes);
        }

        public void DeleteNodes(int id)
        {
            var mainNode = _nodeRepository.Get(id);
            foreach (Node node in mainNode.ChildNodes.ToList())
            {
                if (node.ChildNodes.Count() > 0)
                {
                    DeleteNodes(node.Id);
                }
                else
                {
                    _nodeRepository.Delete(node.Id);
                }
            }
            _nodeRepository.Delete(id);
        }

        public void DeleteAll()
        {
            var nodes = _nodeRepository.GetAll();
            foreach(var node in nodes)
            {
                _nodeRepository.Delete(node.Id);
            }
        }
    }
}