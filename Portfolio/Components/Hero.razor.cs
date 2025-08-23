using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;

namespace Portfolio.Components
{




    public partial class Hero : ComponentBase
    {
        private readonly Random _random = new();


        [Inject] private IJSRuntime JS { get; set; } = default!;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                // Pass the ID of the canvas to JS
                await JS.InvokeVoidAsync("initMatrix", "matrixCanvas");
            }
        }
        [Parameter] public string Name { get; set; } = "Ivan Chris Cano";
        [Parameter] public string Title { get; set; } = "Software Developer";
        [Parameter] public string Summary { get; set; } = "I build clean and modern web applications using Blazor and .NET.";
        private void ScrollToContact()
        {
            // JS interop can scroll to contact form later
        }

        private int RandomDuration()
        {
            return _random.Next(8, 15);   // 8–15 seconds
        }
    }
}
