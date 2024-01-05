using StudentsManagement.DTO.Student;


namespace StudentsManagement.Shared.Forms
{
    public partial class Form_Register
    {
        private Student_DTO studentRegister = new Student_DTO();
        public bool IsInvalidRegister { get; set; }
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
                else if(studentChecked == false)
                {
                    IsInvalidRegister = true;
                    //navigationManager.NavigateTo("/register");
                }
                //else
                //{
                //    navigationManager.NavigateTo("/");
                //}
            }
            catch(ArgumentNullException ar)
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
