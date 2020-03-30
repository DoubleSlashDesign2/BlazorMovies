using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Model
{
    public class TodoModel
    {
        // -- Add model to _Imports.razor to make available global
        public string Text { get; set; }
        public bool Done { get; set; }
    }
}
