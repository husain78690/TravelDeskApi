using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace TravelDeskApi.Models
{
    public class TravelRequest
    {
        public int Id { get; set; }
         public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ProjectName { get; set; }
        public string ReasonForTravel { get; set; }
        public string TypeOfBooking { get; set; } // Air ticket, Hotel, or both
        public DateTime TravelDate { get; set; }
        public string TravelDetails { get; set; } // This can store additional details like Aadhar, Passport, etc.
        public string MealRequired { get; set; }
        public string MealPreference { get; set; } // Veg/Non-Veg
        public string? Status { get; set; } // Pending, Approved, Rejected, etc.
        public string ManagerEmail { get; set; }
        public string? Comments { get; set; }

        // create a FK with User Table
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public User? User { get; set; }

        // create a FK with User Table
        [ForeignKey("ManagerId")]
        public int? ManagerId { get; set; }
        
        public User? Manager { get; set; }

        // create a FK with Department 
        [ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
        
       

        public string Reason { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string FromLocation  { get; set; }
        public string ToLocation { get; set; }

        public int BooingType { get; set; }

        // Add following 5 properties in every class
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; } // is to perform soft delete

    }
}
