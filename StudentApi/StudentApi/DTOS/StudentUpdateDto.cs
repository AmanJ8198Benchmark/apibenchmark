using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOS
{
    public class StudentUpdateDto
    {
        

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                             ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [MaxLength(10)]
        public string MobileNumber
        {
            get; set;
        }
    }
}
