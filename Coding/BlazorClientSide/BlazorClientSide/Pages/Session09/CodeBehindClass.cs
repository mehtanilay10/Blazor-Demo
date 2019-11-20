﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorClientSide.Pages.Session09
{
    [Route("/Session09/CodeBehindClass")]
    public class CodeBehindClass : ComponentBase
    {
        protected string PageTitle = "Blazor Page";
        protected string PageImage = "https://i.imgur.com/8W9UlMJ.png";
        protected List<string> PageDescriptions = new List<string>
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed pretium ante risus, in dignissim nisl dictum sed. Donec ipsum enim, ultrices vel sagittis sed, convallis nec justo. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Sed tincidunt ante lacus, a sagittis quam luctus eu. Phasellus ullamcorper fermentum tempor. Cras nec euismod neque, sed pretium lacus. Suspendisse potenti. Etiam volutpat pharetra justo, ut elementum odio porta et. Pellentesque volutpat, tellus vel efficitur ultricies, mi nisi scelerisque arcu, non pharetra mauris sapien et erat.",
            "Nullam vitae vestibulum risus, sed tempor erat. Nunc eget metus lacus. In eget massa et eros vehicula ultrices quis vel quam. Curabitur et tincidunt nibh, id consequat dolor. Etiam mollis molestie dignissim. Mauris mollis mi enim, ac placerat mauris imperdiet quis. Phasellus at ante sit amet nibh maximus faucibus ac id nisi. Phasellus sed quam purus. Nunc sed ipsum eu sapien iaculis dapibus sit amet eget ipsum. Vestibulum tincidunt interdum lacus, a rutrum risus maximus ac. Aliquam erat volutpat.",
            "Pellentesque bibendum auctor diam, eu cursus metus tincidunt vel. Fusce sit amet lobortis ligula. Curabitur ipsum nulla, interdum a interdum ut, egestas vulputate tellus. Pellentesque pretium lacus lacus, et dictum nulla scelerisque vitae. Donec tempor elementum convallis. Vivamus diam est, fringilla nec porta at, placerat ac mauris. Vivamus bibendum maximus volutpat. Vivamus consectetur aliquam hendrerit. Aliquam quis enim vitae neque interdum pulvinar. Aliquam vehicula eros leo. Duis accumsan ligula ut volutpat bibendum. Nam at feugiat lacus. Phasellus viverra quis dolor varius lacinia. Nunc et lectus fermentum sapien dignissim feugiat. Nam porttitor urna eros, sed tempus odio accumsan ut. Quisque lobortis volutpat placerat.",
            "In sollicitudin sagittis arcu at finibus. Nunc tincidunt, justo non pulvinar porttitor, dolor tellus semper tortor, in feugiat nisl nunc et velit. Vivamus non neque ullamcorper, congue lorem eget, blandit sapien. Nullam mattis, nunc eget gravida finibus, metus lectus ornare nunc, vitae interdum nisi mauris eu sem. Praesent facilisis eu mauris sit amet laoreet. Fusce ac urna ullamcorper ligula sollicitudin malesuada. Curabitur sapien dui, porttitor at efficitur finibus, molestie eget sem. Donec sodales velit non justo volutpat lobortis. Aliquam sit amet dapibus orci. Suspendisse volutpat, diam ut faucibus aliquam, nulla ipsum scelerisque ex, nec pellentesque nisi sem et nisl. Mauris dui tortor, bibendum at pharetra id, hendrerit sit amet lectus. Fusce fermentum, diam eget tempus fermentum, velit lacus viverra orci, quis auctor risus urna facilisis tellus. Cras sagittis justo nunc, sed vulputate ex semper nec.",
            "Morbi luctus imperdiet ante id lobortis. Cras quam nisi, consequat quis tortor vitae, pharetra pretium nulla. Cras imperdiet cursus est, et fermentum neque tempus in. Donec nec lacus eu sapien dapibus condimentum. Fusce eleifend ut diam sit amet sollicitudin. Maecenas in viverra sapien, in lacinia urna. Aliquam tincidunt eros et tincidunt varius. Nulla facilisi. Donec quis ex rhoncus, dictum urna mollis, aliquet tellus."
        };
    }
}
