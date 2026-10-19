using TaskManager1.Views;
namespace TaskManager1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(
            nameof(AddTaskPage),
            typeof(AddTaskPage));

        Routing.RegisterRoute(
            nameof(TaskDetailsPage),
            typeof(TaskDetailsPage));
    }
}