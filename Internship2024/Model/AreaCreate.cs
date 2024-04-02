using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Model
{
    public class AreaCreate
    {
        public string UniqueCode { get; set; }
        public string AreaName { get; set; }
        public string AreaCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool IsForDispensing { get; set; }
        public bool IsActive { get; set; }
    } 
}
