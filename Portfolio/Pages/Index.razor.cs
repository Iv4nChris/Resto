using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;  // <-- Add this

namespace Portfolio.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private IJSRuntime JS { get; set; } = default!;  // <-- JSInterop injection

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                // Call the JS function to observe sections for fade-in/slide-in
                await JS.InvokeVoidAsync("scrollAnimations.observeSections");
            }
        }
    }
}
