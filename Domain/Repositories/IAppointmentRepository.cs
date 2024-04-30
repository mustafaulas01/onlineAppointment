using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using GenericRepository;

namespace Domain.Repositories
{
    public interface IAppointmentRepository:IRepository<Appointment>
    {
        
    }
}