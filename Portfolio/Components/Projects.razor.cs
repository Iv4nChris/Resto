using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    public partial class Projects : ComponentBase
    {
        private class Project
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Link { get; set; }
            public string ImageUrl { get; set; }
        }

        private Project[] ProjectsList = new Project[]
        {
            new Project { Title = "Portfolio Website", Description = "My personal portfolio built with Blazor WASM.", Link = "#", ImageUrl="images/portfolio.png" },
            new Project { Title = "Todo App", Description = "A simple todo app using Blazor and local storage.", Link = "#", ImageUrl="images/todo.png" },
            new Project { Title = "Blog Engine", Description = "A blog engine using ASP.NET Core and EF Core.", Link = "#", ImageUrl="images/blog.png" }
        };
    }
}
