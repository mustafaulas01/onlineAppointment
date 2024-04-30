using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public sealed class AppUser:IdentityUser<Guid>
    {
        
        public string FirstName { get; set; }=string.Empty;

         public string LastName { get; set; }=string.Empty ;

         public string FullName  => string.Join(" ",FirstName,LastName);

    }
}