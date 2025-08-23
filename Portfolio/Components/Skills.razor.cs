using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    public partial class Skills : ComponentBase
    {
        private class Skill
        {
            public string Name { get; set; }
            public string IconClass { get; set; }
        }

        private Skill[] SkillsList = new Skill[]
        {
            new Skill { Name = "C#", IconClass = "fab fa-microsoft" },
            new Skill { Name = ".NET", IconClass = "fas fa-circle-nodes" },
            new Skill { Name = "Blazor", IconClass = "fas fa-fire" },
            new Skill { Name = "SQL", IconClass = "fas fa-database" },
            new Skill { Name = "HTML", IconClass = "fab fa-html5" },
            new Skill { Name = "CSS", IconClass = "fab fa-css3-alt" },
            new Skill { Name = "JavaScript", IconClass = "fa-brands fa-square-js" },
            new Skill { Name = "Git", IconClass = "fa-brands fa-github" }
        };
    }
}
