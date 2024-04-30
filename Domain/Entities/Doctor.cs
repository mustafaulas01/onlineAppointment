using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Doctor
    {

        public Doctor()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName => string.Join(" ", FirstName, LastName);

        public DepartmentEnum Department { get; set; }=DepartmentEnum.GenelCerrahi;
    }
}