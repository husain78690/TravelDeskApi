namespace TravelDeskApi.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        //// Add following 5 properties in every class
        //public int CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public int UpdatedBy { get; set; }
        //public DateTime Updated { get; set; }
        //public bool IsActive { get; set; } // is to perform soft delete

    }
}
