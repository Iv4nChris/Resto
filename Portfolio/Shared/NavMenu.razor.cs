using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Portfolio.Shared
{
    public partial class NavMenu : ComponentBase
    {
        private string currentSection = "home"; // Default active section
        private bool isMenuOpen = false;

        private string NavMenuClass => isMenuOpen ? "nav-links open" : "nav-links";

        private void ToggleMenu()
        {
            isMenuOpen = !isMenuOpen;
        }

        [Inject] private IJSRuntime JS { get; set; } = default!;

        private async Task ScrollTo(string id)
        {
            // Update the active section BEFORE scrolling
            currentSection = id;

            // Trigger re-render to update CSS classes
            StateHasChanged();

            await JS.InvokeVoidAsync("scrollToSection", id);
            // Close mobile menu after click
            isMenuOpen = false;
        }

        private string GetNavButtonClass(string section)
        {
            return currentSection == section
                ? "modern-nav-btn minimal active"
                : "modern-nav-btn minimal";
        }


    }
}
