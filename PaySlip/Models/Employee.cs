namespace PaySlip.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CNIC { get; set; }
        public string City { get; set; }
        public int DeptID { get; set; }
        public Dept Dept { get; set; }

    }
}
