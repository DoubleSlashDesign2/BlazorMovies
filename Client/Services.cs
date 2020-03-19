using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client
{

    /// <summary>
    /// These services get injected in the Program.cs ConfigureServices() method and Main() methods
    /// </summary>
    public class SingletonService
    {
        public int Value { get; set; }
    }

    public class TransientService
    {
        public int Value { get; set; }
    }

}
