function my_function(message) {
    console.log("Console Log from Utilities message is " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript" + result);
        });

}