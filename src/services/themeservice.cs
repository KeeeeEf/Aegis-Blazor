namespace Aegis.Web.Services;

public class ThemeService
{
    public bool IsDarkMode { get; set; } = true;
    
    // Event to notify state changes
    public event EventHandler<EventArgs> Changed;

    // Method to raise the Changed event
    public void NotifyChanged() => Changed?.Invoke(this, EventArgs.Empty);
}