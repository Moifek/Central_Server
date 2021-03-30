using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIOmraneMobileWebAdmin.Widgets
{
    public class ValidationInputBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> ValueChanged { get; set;}

        [Parameter]
        public String PlaceHolder { get; set;}

        [Parameter]
        public string Value { get; set;}

        protected async void HandleInputChanged(ChangeEventArgs args)
        {
            await ValueChanged.InvokeAsync(args.Value.ToString());
        }
    }
}
