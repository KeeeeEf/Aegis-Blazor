namespace Aegis.Web.Services;

public class ThemeService
{
    public bool IsDarkMode { get; set; } = true;
    
    public event EventHandler<EventArgs>? Changed;

    public void NotifyChanged() => Changed?.Invoke(this, EventArgs.Empty);
}