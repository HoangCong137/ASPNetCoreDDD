using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Employees.Employee;

namespace Domain.Deparment
{
    public class Department : BaseEntity
    {
        public int Department_ID { get; set; }
        public string Name { get; set; }
    }
}
