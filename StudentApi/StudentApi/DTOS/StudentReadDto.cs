using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOS
{
    public class StudentReadDto
    {
        
        public int StudentId { get; set; }

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

       
        public string Email { get; set; }

    
        public string MobileNumber
        {
            get; set;
        }
    }
}
