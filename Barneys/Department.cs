using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barneys
{
    public class Department
    {
        public string Name { get; set; }

        public string Alias { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public List<Flow> Flows { get; set; }
    }
}
