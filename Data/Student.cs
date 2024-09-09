namespace BlazorApp.Data
{
    public class Student 
    {

        public string StudentNo { get; set; }=string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } =string.Empty;
        public DateTime DOB { get; set; } = DateTime.Now;

       

        public string Phone { get; set; } = string.Empty;

       


    }
}
