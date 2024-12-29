namespace Aegis.Web.Components.Common;

public partial class Header 
{
    private bool _open;

    private void ToggleDrawer()
    {
        _open = !_open;
    }

    protected override void OnInitialized()
    {
        ThemeService.Changed += DoUpdate;
    }

    private void DoUpdate(object? sender, EventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }

    public void ChangeTheme()
    {
        ThemeService.IsDarkMode = !ThemeService.IsDarkMode;
        ThemeService.NotifyChanged();
    }
}