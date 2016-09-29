using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFish.LabSystem.DataModel.Entities
{
    public class ResourceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public List<Resource> Resources { get; set; }
    }

    public class Resource
    {
        public int Id { get; set; }
        public ResourceType Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public ResourceCategory Category { get; set; }
    }

    public enum ResourceType
    {
        Page
    }
}
