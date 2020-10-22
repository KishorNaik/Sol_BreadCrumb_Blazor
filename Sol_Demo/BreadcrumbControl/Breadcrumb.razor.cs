using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreadcrumbControl
{
    public partial class Breadcrumb
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}