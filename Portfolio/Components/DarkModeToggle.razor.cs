using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Portfolio.Components
{
    public partial class DarkModeToggle : ComponentBase
    {
        private bool isDark = false;
        private string ButtonText => isDark ? "☀️" : "🌙";

        [Inject] private IJSRuntime JS { get; set; } = default!;

        private async Task ToggleDarkMode()
        {
            isDark = !isDark;
            if (isDark)
            {
                await JS.InvokeVoidAsync("document.body.classList.add", "dark-mode");
            }
            else
            {
                await JS.InvokeVoidAsync("document.body.classList.remove", "dark-mode");
            }
        }
    }
}
