using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreeView.Nodes
{
    [Table("Nodes")]
    public class Node : Entity, IHasCreationTime
    {
        //[ForeignKey("SubItems")]
        //public virtual Node SubItems { get; set; }

        [Required]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }
        public virtual DateTime CreationTime { get; set; }

        public virtual int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual Node ParentNode { get; set; }

        public virtual int Layer { get; set; }
        public virtual ICollection<Node> ChildNodes { get; set; }

        public Node()
        {
            CreationTime = DateTime.Now;
            //List<Node> ChildNodes = new List<Node>();
        }
    }
}
