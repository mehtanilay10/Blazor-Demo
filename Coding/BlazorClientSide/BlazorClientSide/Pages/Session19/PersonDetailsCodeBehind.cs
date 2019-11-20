using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorClientSide.Pages.Session19
{
    [Route("/Session19/PersonDetails")]
    public class PersonDetailsCodeBehind : ComponentBase
    {
        [Parameter]
        public string Name { get; set; } = "Nilay";

        [Parameter]
        public string Mobile { get; set; } = "987654";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.OpenElement(0, "p");
            builder.OpenElement(1, "b");
            builder.AddContent(2, "Name:");
            builder.CloseElement();
            builder.AddContent(3, Name);
            builder.OpenElement(4, "br");
            builder.CloseElement();
            builder.OpenElement(5, "b");
            builder.AddContent(6, "Mobile:");
            builder.CloseElement();
            builder.AddContent(7, Mobile);
            builder.CloseElement();
        }
    }
}
