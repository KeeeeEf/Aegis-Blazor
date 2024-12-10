using MudBlazor;

namespace Aegis.Web.Components.Layout;

public partial class MainLayout {
        public MudTheme CustomTheme = new()
        {
            PaletteLight = new PaletteLight()
            {
                Background = "#FFFFFF",
                PrimaryLighten = "#0033AD",
                Primary = "#0B286D",
                PrimaryDarken = "#000F33",
                SecondaryLighten = "#F9F9F9",
                Secondary = "#FFFFFF",
                SecondaryDarken = "#495B83",
                TextPrimary = "#323E59"
            },
            PaletteDark = new PaletteDark()
            {
                Background = "#000F33",
                PrimaryLighten = "#000F33",
                Primary = "#0B1A3D",
                PrimaryDarken = "#0033AD",
                SecondaryLighten = "#FFFFFF",
                Secondary = "#3C92F9",
                SecondaryDarken = "#0042E1",
                TextPrimary = "#FFFFFF",
            },
        };

    public bool IsDarkMode = true;
    public void ThemeSwitcher()
    {
        IsDarkMode = !IsDarkMode;
    }
}