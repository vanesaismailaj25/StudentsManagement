#region Usings
using DevExpress.Blazor;
using StudentsManagement.DAL.Models;
using Microsoft.AspNetCore.Components;
using StudentsManagement.Helpers.Mappers;
using StudentsManagement.BLL.Repository.Interfaces;
#endregion

namespace StudentsManagement.Shared.Grids.Dashboard;

/// <summary>
///     The partial/Code part of the <see cref="Gridi_StudentConsole"/> razor component.
/// </summary>
public partial class Gridi_StudentConsole
{
    #region Injections
    /// <summary>
    ///     The <see cref="IStudentRepository"/>
    /// </summary>
    [Inject] IStudentRepository studentRepository { get; set; } = null!;
    #endregion

    #region Properties
    /// <summary>
    ///     A trigger for <see cref="DxPopup"/> in this component.
    /// </summary>
    private bool PopUpVisible { get; set; } = false;
    /// <summary>
    ///     A list of <see cref="Student"/> used in the <see cref="DxGrid"/> in this component.
    /// </summary>
    private IEnumerable<Student>? Data { get; set; }
    /// <summary>
    ///     The message of the popup.
    /// </summary>
    private string PopUpMessage { get; set; } = string.Empty;
    #endregion

    #region Methods

    protected override async Task OnInitializedAsync()
    {
        Data = await studentRepository.GetAllStudentsAsync();
    }
    /// <summary>
    ///     Edit or create a new student.
    /// </summary>
    /// <param name="e"> The <see cref="GridEditModelSavingEventArgs"/> event </param>
    /// <returns> A task representing any asynchronous operation </returns>
    async Task OnEditModelSaving(GridEditModelSavingEventArgs e)
    {
        PopUpVisible = false;

        var editModelDto = ((Student)e.EditModel).AS_Students_DTO();

        if (e.IsNew)
        {
            studentRepository.CreateStudent(editModelDto);
            Data = await studentRepository.GetAllStudentsAsync();
            return;
        }

        var result = await studentRepository.UpdateStudentAsync(editModelDto);

        PopUpVisible = true;

        if (result is not "")
            PopUpMessage = result;
        else
            PopUpMessage = $"User {editModelDto.Email} updated successfully";
    }
    /// <summary>
    ///     Delete a student.
    /// </summary>
    /// <param name="e"> The <see cref="GridDataItemDeletingEventArgs"/> event </param>
    /// <returns> A task representing any asynchronous operation </returns>
    async Task OnDataItemDeleting(GridDataItemDeletingEventArgs e)
    {
        //re-query a data item from the database
        var dataItem = studentRepository.FindAsync((e.DataItem as Student).PhoneNumber);
        if (dataItem != null)
        {
            //remove the item from the database 
            await studentRepository.DeleteStudentAsync(await dataItem);
        }
        //reload the entire Grid
        //Data = await studentRepository.GetAllStudentsAsync();
    }

    #endregion
}
