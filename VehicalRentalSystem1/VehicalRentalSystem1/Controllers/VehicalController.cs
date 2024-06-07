using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Security.Claims;
using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.Services;
using VehicalRentalSystem1.ViewModel;

namespace VehicalRentalSystem1.Controllers
{
    public class VehicalController : Controller
    {
        private readonly VehicalService _vehicalService;
        private readonly VehicalRentalSystemContext _vehicalRentalSystemContext;
        
        public VehicalController(VehicalService vehicalService,VehicalRentalSystemContext vehicalRentalSystemContext)
        {
            _vehicalService = vehicalService;
            _vehicalRentalSystemContext = vehicalRentalSystemContext;
        }
        public IActionResult AddVehical()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVehical(VehicalViewModel vehical)
        {
          

            if (ModelState.IsValid)
            {
                string imagePath = await UploadImage(vehical.Vehical_Photo);

                _vehicalService.RegisterVehical(vehical, GetUserId(), imagePath);
            }

            //TempData["Success"] = "Registered Successfully";
            return RedirectToAction("RentEarn","User");
        }


        public IActionResult ListVehical()
        {
           
            List<Vehical> vehicalViewModels = GetVehicalViewModelsFromDatabase();



            // Pass the list of VehicalViewModel instances to the view
            return View(vehicalViewModels);
        }

        public List<Vehical> GetVehicalViewModelsFromDatabase()
        {
            // Retrieve Vehical entities from the database
            Guid x1 = Guid.Parse(GetUserId());
            List<Vehical> vehicals = _vehicalRentalSystemContext.Vehicals.Where(v => v.UserId == x1).ToList();

            // Map Vehical entities to VehicalViewModel instances
            List<Vehical> vehicalViewModels = vehicals.Select(v => new Vehical
            {
                VehicalId = v.VehicalId,
                Model = v.Model,
                Year = v.Year,
                Type = v.Type,
                LicenseNo = v.LicenseNo,
                Color = v.Color,
                Mileage = v.Mileage,
                AvailabilityStatus = v.AvailabilityStatus,
                RentalRatePerHour = v.RentalRatePerHour,
                InsuranceAvailable = v.InsuranceAvailable,
                InsuranceInfo = v.InsuranceInfo,
                Vehical_Photo = v.Vehical_Photo
            }).ToList();

            return vehicalViewModels;
        }

        public VehicalViewModel GetVehicalViewModelById(Guid vehicalId)
        {
            var vehical = _vehicalRentalSystemContext.Vehicals.FirstOrDefault(v => v.VehicalId == vehicalId);
            if (vehical == null)
            {
                return null; // or handle not found case as needed
            }

            var vehical1 = new VehicalViewModel
            {
                VehicalId = vehical.VehicalId,
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
                //Vehical_Photo = vehical.Vehical_Photo
            };

            return vehical1;
        }


        public IActionResult DeleteVehical()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteVehical(Guid id)
        {
            var vehicle = _vehicalRentalSystemContext.Vehicals.FirstOrDefault(v => v.VehicalId == id);
            if (vehicle != null)
            {
                _vehicalRentalSystemContext.Vehicals.Remove(vehicle);
                _vehicalRentalSystemContext.SaveChanges();
            }
           
            return RedirectToAction("ListVehical");
        }

        public async Task<IActionResult> UpdateVehical(Guid? id,string? y)
        {
    
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _vehicalRentalSystemContext.Vehicals.FindAsync(id);
            //Console.WriteLine("Vehicle Photo Path: " + vehicle.Vehical_Photo);
            if (vehicle == null)
            {
                return NotFound();
            }
            vehicle.InsuranceInfo = y;
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        [HttpPost]
        public async Task<IActionResult> UpdateVehical(string? x, VehicalViewModel vehicle)
        { 
           
            Console.WriteLine("Post method value: "+x);
            var y = GetUserId();
            Guid x1 = Guid.Parse(y);
            var z = vehicle.LicenseNo;
            if (ModelState.IsValid)
            {
                var entity = new Vehical()
                {
                    VehicalId = vehicle.VehicalId,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Type = vehicle.Type,
                    LicenseNo = vehicle.LicenseNo,
                    Color = vehicle.Color,
                    Mileage = vehicle.Mileage,
                    AvailabilityStatus = vehicle.AvailabilityStatus,
                    RentalRatePerHour = vehicle.RentalRatePerHour,
                    InsuranceAvailable = vehicle.InsuranceAvailable,
                    InsuranceInfo = vehicle.InsuranceInfo,
                    Vehical_Photo = x,
                    UserId = x1
                };

                var vehicle1 = _vehicalRentalSystemContext.Vehicals.FirstOrDefault(v => v.Model == vehicle.Model);
                if (vehicle1 != null)
                {
                    _vehicalRentalSystemContext.Vehicals.Remove(vehicle1);
                    _vehicalRentalSystemContext.SaveChanges();
                }

                _vehicalRentalSystemContext.Vehicals.Add(entity);
            _vehicalRentalSystemContext.SaveChanges();


            return RedirectToAction("ListVehical");

            }
            return View();
        }

        private bool VehicleExists(Guid id)
        {
            return _vehicalRentalSystemContext.Vehicals.Any(e => e.VehicalId == id);
        }



    private string GetUserId()
        {
            var UserData = User.FindFirst(ClaimTypes.Email)?.Value;
            var user = _vehicalRentalSystemContext.Users.FirstOrDefault(u => u.Email == UserData);
            if (user != null)
            {
                var UserId = user.UserId.ToString();
                return UserId;
            }
            var UserId1 = _vehicalRentalSystemContext.Users.FirstOrDefault(u => u.Email == UserData)!.UserId.ToString();
            return UserId1;
        }

        public async Task<string> UploadImage(IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                try
                {

                    var uploadsFolder = "C:\\vs code\\C#\\VehicalRentalSystem1\\VehicalRentalSystem1\\wwwroot\\VehicalImages\\";


                    var uniqueFileName = imageFile.FileName;

                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    Directory.CreateDirectory(uploadsFolder);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }
                    return "/VehicalImages/" + uniqueFileName;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    return "/VehicalImages/";
                }
            }
            else
            {

                return "/VehicalImages/background.jpg";
            }
        }

        public List<Vehical> GetVehicalViewModels()
        {
            // Retrieve Vehical entities from the database
            Guid x1 = Guid.Parse(GetUserId());
            List<Vehical> vehicals = _vehicalRentalSystemContext.Vehicals.ToList();

            // Map Vehical entities to VehicalViewModel instances
            List<Vehical> vehicalViewModels = vehicals.Select(v => new Vehical
            {
                VehicalId = v.VehicalId,
                Model = v.Model,
                Year = v.Year,
                Type = v.Type,
                LicenseNo = v.LicenseNo,
                Color = v.Color,
                Mileage = v.Mileage,
                AvailabilityStatus = v.AvailabilityStatus,
                RentalRatePerHour = v.RentalRatePerHour,
                InsuranceAvailable = v.InsuranceAvailable,
                InsuranceInfo = v.InsuranceInfo,
                Vehical_Photo = v.Vehical_Photo
            }).ToList();

            return vehicalViewModels;
        }

        public IActionResult MyTrips()
        {

            List<Vehical> vehicalViewModels = GetVehicalViewModels();



            // Pass the list of VehicalViewModel instances to the view
            return View(vehicalViewModels);
        }

        public IActionResult FilterVehicles()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilterVehicles(VehicleFilterModel filter)
        {
            var vehicles = _vehicalRentalSystemContext.Vehicals.AsQueryable();

            if (filter.VehicleTypes != null && filter.VehicleTypes.Any())
            {
                vehicles = vehicles.Where(v => filter.VehicleTypes.Contains(v.Type));
            }

            if (!string.IsNullOrEmpty(filter.PriceOrder))
            {
                if (filter.PriceOrder == "HighToLow")
                {
                    vehicles = vehicles.OrderByDescending(v => v.RentalRatePerHour);
                }
                else if (filter.PriceOrder == "LowToHigh")
                {
                    vehicles = vehicles.OrderBy(v => v.RentalRatePerHour);
                }
            }

            if (!string.IsNullOrEmpty(filter.MileageOrder))
            {
                if (filter.MileageOrder == "HighToLow")
                {
                    vehicles = vehicles.OrderByDescending(v => v.Mileage);
                }
                else if (filter.MileageOrder == "LowToHigh")
                {
                    vehicles = vehicles.OrderBy(v => v.Mileage);
                }
            }

            return View(vehicles.ToList());
        }
    }

}

