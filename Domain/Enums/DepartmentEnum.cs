using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;

namespace Domain.Enums
{
    public sealed class DepartmentEnum : SmartEnum<DepartmentEnum>
    {

        public static readonly DepartmentEnum Acil = new DepartmentEnum("Acil", 1);
        public static readonly DepartmentEnum Radyoloji = new DepartmentEnum("Radyoloji", 2);
        public static readonly DepartmentEnum Dermatoloji = new DepartmentEnum("Dermatoloji", 3);
         public static readonly DepartmentEnum GenelCerrahi = new DepartmentEnum("Genel Cerrahi", 4);
         public static readonly DepartmentEnum Nöroloji = new DepartmentEnum("Nöroloji", 5);
         public static readonly DepartmentEnum Ortopedi = new DepartmentEnum("Ortopedi", 6);
         public static readonly DepartmentEnum Psikiyatri = new DepartmentEnum("Psikiyatri", 7);
         public static readonly DepartmentEnum Hemetoloji = new DepartmentEnum("Hemetoloji", 8);

        public DepartmentEnum(string name, int value) : base(name, value)
        {

        }
    }
}