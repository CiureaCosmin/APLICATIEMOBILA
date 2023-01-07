using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI.Models;

namespace MAUI.Data.AppointmentsService
{
    public class AppointmentDatabase
    {
        IAppointmentService AppointmentService;
       
        public AppointmentDatabase(IAppointmentService service)
        {
            AppointmentService = service;
        }
        public Task<List<Appointment>> GetAppointmentAsync()
        {
            return AppointmentService.RefreshDataAsync();
        }

        public Task SaveAppointmentAsync(Appointment item, bool isNewItem = true)
        {
            return AppointmentService.SaveAppointmentAsync(item, isNewItem);
        }
        public Task DeleteAppointmentAsync(Appointment item)
        {
            return AppointmentService.DeleteAppointmentAsync(item.Id);
        }

    }
}    
