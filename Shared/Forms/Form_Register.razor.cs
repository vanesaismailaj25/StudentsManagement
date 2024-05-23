using StudentsManagement.DTO.Student;


namespace StudentsManagement.Shared.Forms
{
    public partial class Form_Register
    {
        private Student_DTO studentRegister = new Student_DTO();
        private DateTime DateOfBirth { get; set; } = DateTime.Now;
        private DateTime DateOfRegistration { get; set; } = DateTime.Now;
        public bool IsInvalidRegister { get; set; }
        protected void RegisterStudent()
        {
            try
            {
                studentRegister.DateOfBirth = DateOfBirth;
                studentRegister.RegistrationYear = DateOfRegistration;
                var studentChecked = studentRepository.GetStudentByPhoneNumber(studentRegister.PhoneNumber);

                if (studentChecked == false)
                {
                    var result = studentRepository.CreateStudent(studentRegister);
                    if (result != null)
                    {
                        navigationManager.NavigateTo("/studentpage");
                    }
                    else
                    {
                        IsInvalidRegister = true;
                    }
                }
                //else if(studentChecked == false)
                //{
                //    IsInvalidRegister = true;
                //    //navigationManager.NavigateTo("/register");
                //}
                //else
                //{
                //    navigationManager.NavigateTo("/");
                //}
            }
            catch (ArgumentNullException ar)
            {
                Console.WriteLine(ar.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
