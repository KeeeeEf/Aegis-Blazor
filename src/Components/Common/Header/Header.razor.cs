using Microsoft.AspNetCore.Components;

namespace Aegis.Web.Components.Common;

public partial class Header {
    [CascadingParameter] public bool IsDarkMode { get; set; }

    private bool _open;

    private void ToggleDrawer()
    {
        _open = !_open;
    }
}