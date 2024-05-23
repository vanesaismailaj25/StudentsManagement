using Microsoft.AspNetCore.Components;
using StudentsManagement.DTO.Student;
namespace StudentsManagement.Shared.Forms;

public partial class Form_Login
{
    private StudentLogin_DTO loginForm = new StudentLogin_DTO();
    public bool IsInvalidLogin { get; set; }

    protected async Task LoginRequest()
    {
        try
        {
            var result = await LoginRepository.Login(loginForm);
            if (result)
            {
                NavigationManager.NavigateTo("/personal-profile");
            }
            else
            {
                IsInvalidLogin = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
