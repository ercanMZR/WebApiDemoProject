namespace WebApiDemoProject.Models
{
    public class AdminUser:BaseEntity
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        
        public string Email { get; set; }

        public string Phone {  get; set; }



    }
}
