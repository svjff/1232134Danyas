using Microsoft.Extensions.Logging;
using TaskManager1.Services;
using TaskManager1.Views;

namespace TaskManager1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<TaskService>();
        builder.Services.AddTransient<TaskListPage>();
        builder.Services.AddTransient<AddTaskPage>();
        builder.Services.AddTransient<TaskDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}