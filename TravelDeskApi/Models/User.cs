using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelDeskApi.Models
{
    public class User
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
        // this will create Fk to DEpartment class
        //[ForeignKey("DepartmentId")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        
        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public User? Manager { get; set; }
        public List<User>? Users { get; set; }



        // this will create FK to Role Table
        public int? RoleId { get; set; }
        public Role? Role { get; set; }


        //[ForeignKey("ManagerId")]
        //public int? ManagerId { get; set; }
        ////[ForeignKey("ManagerId")]
        //public User? Manager { get; set; }
        

        // Add following 5 properties in every class
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsActive { get; set; } // is to perform soft delete

    }
      
  
}

