using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleFish.LabSystem.DataModel.Entities
{
    public class Laboratory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime ArchiveDate { get; set; }
        public string Notes { get; set; }
    }
}
