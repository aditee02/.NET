using System.Security.Claims;
using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.ViewModel;

namespace VehicalRentalSystem1.Services
{
    public class VehicalService
    {
        private readonly VehicalRentalSystemContext _context;
        private readonly ValidationService _validationService;
        public VehicalService(VehicalRentalSystemContext context,ValidationService validationService)
        {
            _context = context;
            _validationService = validationService;
        }
        public bool RegisterVehical(VehicalViewModel vehical,string UserId,string imagePath)
        {
            Guid x = Guid.Parse(UserId);

            Vehical vr = new Vehical()
            {   VehicalId = vehical.VehicalId,
                UserId = x,
                Model = vehical.Model,
                Year = vehical.Year,
                Type = vehical.Type,
                LicenseNo = vehical.LicenseNo,
                Color = vehical.Color,
                Mileage = vehical.Mileage,
                AvailabilityStatus = vehical.AvailabilityStatus,
                RentalRatePerHour = vehical.RentalRatePerHour,
                InsuranceAvailable = vehical.InsuranceAvailable,
                InsuranceInfo = vehical.InsuranceInfo,
                Vehical_Photo = imagePath

            };
            _context.Vehicals.Add(vr);
            _context.SaveChanges();
            return true;
        }
       
    }
}