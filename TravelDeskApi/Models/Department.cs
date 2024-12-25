namespace TravelDeskApi.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        //// Add following 5 properties in every class
        //public int CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public int UpdatedBy { get; set; }
        //public DateTime Updated { get; set; }
        //public bool IsActive { get; set; } // is to perform soft delete

    }
}
