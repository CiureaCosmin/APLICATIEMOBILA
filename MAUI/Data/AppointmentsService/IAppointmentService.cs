using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.AppointmentsService
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> RefreshDataAsync();
        Task SaveAppointmentAsync(Appointment item, bool isNewItem);
        Task DeleteAppointmentAsync(string Id);
    }
}
