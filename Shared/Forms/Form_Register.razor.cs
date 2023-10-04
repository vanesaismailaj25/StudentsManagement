using StudentsManagement.DAL.Models;
using StudentsManagement.DTO.Student;


namespace StudentsManagement.Shared.Forms
{
    public partial class Form_Register
    {
        private Student_DTO studentRegister = new Student_DTO();

        protected void RegisterStudent()
        {
            try
            {
                var studentChecked = studentRepository.GetStudentByPhoneNumber(studentRegister.PhoneNumber);

                if (studentChecked == true)
                {
                    studentRepository.CreateStudent(studentRegister);     
                    navigationManager.NavigateTo("/studentpage");
                }
                else
                {
                    navigationManager.NavigateTo("/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
