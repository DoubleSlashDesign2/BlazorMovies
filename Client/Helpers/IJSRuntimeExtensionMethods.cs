using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.JSInterop;  //  for IJSRuntime

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Example Console Log Message from confirm");
            return await js.InvokeAsync<bool>("confirm", message);
        }

        //-- we are not expecting back a value like bool above
        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Example Console Log Message from MyFunction");
            await js.InvokeVoidAsync("my_function", message);
        }

    }
}
