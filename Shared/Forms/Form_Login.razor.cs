using Microsoft.AspNetCore.Components;
using StudentsManagement.DTO.Student;
namespace StudentsManagement.Shared.Forms;

public partial class Form_Login
{
    private StudentLogin_DTO loginForm = new StudentLogin_DTO();
    
    protected async Task LoginRequest()
    {
        try
        {
            var result = await LoginRepository.Login(loginForm);
            if (result)
            {
                NavigationManager.NavigateTo("/studentpage");
            }
            else
            {
                NavigationManager.NavigateTo("/error");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
