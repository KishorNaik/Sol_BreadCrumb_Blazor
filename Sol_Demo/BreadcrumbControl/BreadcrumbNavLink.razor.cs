using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreadcrumbControl
{
    public partial class BreadcrumbNavLink
    {
        [Parameter]
        public String Name { get; set; }

        [Parameter]
        public String Href { get; set; }

        [Parameter]
        public bool IsActive { get; set; }
    }
}