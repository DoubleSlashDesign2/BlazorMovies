using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{

    //-- make sure you add the partial modifer tag when creating a partial razor class
    public partial class Counter
    {
        // -- instead of the @inject directive which is used in the razor pages we use the 
        // -- [Inject] attribute and make the item a property to accomplish the same as in the razor pages
        [Inject] SingletonService singleton { get; set; } 
        [Inject] TransientService transient { get; set; }

        private List<Movie> movieLists;

        protected async override Task OnInitializedAsync()
        //protected override void OnInitialized()
        {
            await Task.Delay(3000);

            movieLists = new List<Movie>(){
            new Movie() { Title = "joker", ReleaseDate = new DateTime(2019, 7, 2)},
            new Movie() { Title = "Batman", ReleaseDate = new DateTime(2016, 11, 23)},
            new Movie() { Title = "Avenders", ReleaseDate = new DateTime(2010, 7, 16)}
        };

        }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }

    }
}
