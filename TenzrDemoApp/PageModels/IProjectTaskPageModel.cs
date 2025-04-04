using CommunityToolkit.Mvvm.Input;
using TenzrDemoApp.Models;

namespace TenzrDemoApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}