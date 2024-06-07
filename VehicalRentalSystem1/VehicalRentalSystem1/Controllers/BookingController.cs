using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using VehicalRentalSystem1.Models;
using VehicalRentalSystem1.Services;
using VehicalRentalSystem1.ViewModel;
using Newtonsoft.Json;

namespace VehicalRentalSystem1.Controllers
{
    public class BookingController : Controller
    {
        private readonly VehicalRentalSystemContext _context;
        private static readonly Dictionary<string, string> userConnections = new Dictionary<string, string>();
        public BookingController(VehicalRentalSystemContext vehicalRentalSystemContext)
        {
            _context = vehicalRentalSystemContext;
        }

        [HttpGet]
        public IActionResult BookVehicle(Guid vehicalId)
        {
            var model = new BookingViewModel
            {
                VehicalId = vehicalId,
                RentalStartDate = DateTime.Now,
                RentalEndDate = DateTime.Now.AddDays(1)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult BookVehicle(Booking bookingViewModel)
        {
            if (ModelState.IsValid)
            {
                Guid x = Guid.Parse(GetUserId());
                var booking = new Booking
                {
                    BookingId = Guid.NewGuid(),
                    UserId = x,  
                    VehicalId = bookingViewModel.VehicalId,
                    RentalStartDate = bookingViewModel.RentalStartDate,
                    RentalEndDate = bookingViewModel.RentalEndDate,
                    TotalRentalCost =(decimal) CalculateTotalRentalCost(bookingViewModel),
                    InsuranceOption = bookingViewModel.InsuranceOption,
                    PickupLocation = bookingViewModel.PickupLocation,
                    DropOffLocation = bookingViewModel.DropOffLocation,
                    AdditionalCharges = bookingViewModel.AdditionalCharges
                };
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                var vehicle = _context.Vehicals.FirstOrDefault(v => v.VehicalId == bookingViewModel.VehicalId);
                BookingVehicleViewModel bv = new BookingVehicleViewModel {

                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Type = vehicle.Type,
                    LicenseNo = vehicle.LicenseNo,
                    Color = vehicle.Color,
                    Mileage = vehicle.Mileage,
                    AvailabilityStatus = false,
                    RentalRatePerHour = vehicle.RentalRatePerHour,
                    InsuranceAvailable = vehicle.InsuranceAvailable,
                    InsuranceInfo = vehicle.InsuranceInfo,
                    Vehical_Photo =vehicle.Vehical_Photo ,

                    BookingId = booking.BookingId,
                    UserId = x,  
                    VehicalId = bookingViewModel.VehicalId,
                    RentalStartDate = bookingViewModel.RentalStartDate,
                    RentalEndDate = bookingViewModel.RentalEndDate,
                    TotalRentalCost =(decimal) CalculateTotalRentalCost(booking),
                    InsuranceOption = bookingViewModel.InsuranceOption,
                    PickupLocation = bookingViewModel.PickupLocation,
                    DropOffLocation = bookingViewModel.DropOffLocation,
                    AdditionalCharges = bookingViewModel.AdditionalCharges
                };
               
                 return RedirectToAction("BookingConfirmation", bv);
            }
            return View(bookingViewModel);
        }
        public IActionResult PDFMethod()
        {

            return View();
        }
        [HttpPost]
        public IActionResult PDFMethod(Guid id,Guid id2)
        {
            Guid x = Guid.Parse(GetUserId());
            var booking = _context.Bookings.FirstOrDefault(v => v.VehicalId == id);
            var vehicle = _context.Vehicals.FirstOrDefault(v => v.VehicalId == id);
            BookingVehicleViewModel bv = new BookingVehicleViewModel
            {

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
                Vehical_Photo = vehicle.Vehical_Photo,

                BookingId = booking.BookingId,
                UserId = x,  
                VehicalId = booking.VehicalId,
                RentalStartDate = booking.RentalStartDate,
                RentalEndDate = booking.RentalEndDate,
                TotalRentalCost = (decimal)CalculateTotalRentalCost(booking),
                InsuranceOption = booking.InsuranceOption,
                PickupLocation = booking.PickupLocation,
                DropOffLocation = booking.DropOffLocation,
                AdditionalCharges = booking.AdditionalCharges
            };
            var pdf = GenerateBookingPdf(bv);

            var fileName = $"Booking_{bv.BookingId}.pdf";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "pdfs", fileName);
            System.IO.File.WriteAllBytes(path, pdf);
            var fileResult = File(pdf, "application/pdf", fileName);

            return File(pdf, "application/pdf", fileName);
     

        }
        private byte[] GenerateBookingPdf(BookingVehicleViewModel booking)
        {
            using (var ms = new MemoryStream())
            {
                var document = new Document(PageSize.A4, 50, 50, 25, 25);
                PdfWriter.GetInstance(document, ms);
                document.Open();

                // Title
                var titleFont = FontFactory.GetFont("Arial", 20, Font.BOLD);
                var subTitleFont = FontFactory.GetFont("Arial", 16, Font.BOLD);
                var bodyFont = FontFactory.GetFont("Arial", 12, Font.NORMAL);
                var boldBodyFont = FontFactory.GetFont("Arial", 12, Font.BOLD);

                document.Add(new Paragraph("Booking Confirmation", titleFont) { Alignment = Element.ALIGN_CENTER });
                document.Add(new Paragraph("\n\n"));

                // Booking Details
                document.Add(new Paragraph("Booking Details", subTitleFont));
                document.Add(new Paragraph("\n"));

                var bookingTable = new PdfPTable(2)
                {
                    WidthPercentage = 100,
                    HorizontalAlignment = Element.ALIGN_LEFT
                };

                // Booking ID
                bookingTable.AddCell(new PdfPCell(new Phrase("Booking ID:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.BookingId.ToString(), bodyFont)) { Border = 0 });


                //vehicle details

                // Model
                bookingTable.AddCell(new PdfPCell(new Phrase("Model:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.Model, bodyFont)) { Border = 0 });

                // Year
                bookingTable.AddCell(new PdfPCell(new Phrase("Year:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.Year.ToString(), bodyFont)) { Border = 0 });

                // Type
                bookingTable.AddCell(new PdfPCell(new Phrase("Type:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.Type, bodyFont)) { Border = 0 });

                // License No
                bookingTable.AddCell(new PdfPCell(new Phrase("License No:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.LicenseNo, bodyFont)) { Border = 0 });

                // Color
                bookingTable.AddCell(new PdfPCell(new Phrase("Color:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.Color, bodyFont)) { Border = 0 });

                // Mileage
                bookingTable.AddCell(new PdfPCell(new Phrase("Mileage:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.Mileage.ToString(), bodyFont)) { Border = 0 });

              
                // Rental Rate Per Hour
                bookingTable.AddCell(new PdfPCell(new Phrase("Rental Rate Per Hour:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.RentalRatePerHour.ToString("C"), bodyFont)) { Border = 0 });

                // Insurance Available
                bookingTable.AddCell(new PdfPCell(new Phrase("Insurance Available:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.InsuranceAvailable ? "Yes" : "No", bodyFont)) { Border = 0 });

                // Insurance Info
                bookingTable.AddCell(new PdfPCell(new Phrase("Insurance Info:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.InsuranceInfo, bodyFont)) { Border = 0 });

                // Rental Start Date
                bookingTable.AddCell(new PdfPCell(new Phrase("Rental Start Date:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.RentalStartDate.ToString("g"), bodyFont)) { Border = 0 });

                // Rental End Date
                bookingTable.AddCell(new PdfPCell(new Phrase("Rental End Date:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.RentalEndDate.ToString("g"), bodyFont)) { Border = 0 });

                // Total Rental Cost
                bookingTable.AddCell(new PdfPCell(new Phrase("Total Rental Cost:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.TotalRentalCost.ToString("C"), bodyFont)) { Border = 0 });

                // Insurance Option
                bookingTable.AddCell(new PdfPCell(new Phrase("Insurance Option:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.InsuranceOption ? "Yes" : "No", bodyFont)) { Border = 0 });

                // Pickup Location
                bookingTable.AddCell(new PdfPCell(new Phrase("Pickup Location:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.PickupLocation, bodyFont)) { Border = 0 });

                // Drop Off Location
                bookingTable.AddCell(new PdfPCell(new Phrase("Drop Off Location:", boldBodyFont)) { Border = 0 });
                bookingTable.AddCell(new PdfPCell(new Phrase(booking.DropOffLocation, bodyFont)) { Border = 0 });

                // Additional Charges
                if (booking.AdditionalCharges.HasValue)
                {
                    bookingTable.AddCell(new PdfPCell(new Phrase("Additional Charges:", boldBodyFont)) { Border = 0 });
                    bookingTable.AddCell(new PdfPCell(new Phrase(booking.AdditionalCharges.Value.ToString("C"), bodyFont)) { Border = 0 });
                }

                document.Add(bookingTable);

                document.Add(new Paragraph("\n\nThank you for booking with us!", boldBodyFont) { Alignment = Element.ALIGN_CENTER });
                document.Close();

                return ms.ToArray();
            }
        }
            private double CalculateTotalRentalCost(Booking bookingViewModel)
        {
            var vehicle = _context.Vehicals.FirstOrDefault(v => v.VehicalId == bookingViewModel.VehicalId);
            TimeSpan difference = bookingViewModel.RentalEndDate - bookingViewModel.RentalStartDate;
            double totalHours = difference.TotalHours;
            return totalHours * vehicle.RentalRatePerHour;
        }

        public IActionResult BookingConfirmation(BookingVehicleViewModel booking)
        {
            return View(booking);
        }
     
        private string GetUserId()
        {
            var UserData = User.FindFirst(ClaimTypes.Email)?.Value;
            var user = _context.Users.FirstOrDefault(u => u.Email == UserData);
            if (user != null)
            {
                var UserId = user.UserId.ToString();
                return UserId;
            }
            var UserId1 = _context.Users.FirstOrDefault(u => u.Email == UserData)!.UserId.ToString();
            return UserId1;
        }

        //chat feature
        public IActionResult ChatMethod()
        {
            return View();
        }

    }
}
