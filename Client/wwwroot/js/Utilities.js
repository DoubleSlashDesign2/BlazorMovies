function my_function(message) {
    console.log("Console Log from Utilities message is " + message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from javascript" + result);
        });

}

function dotnetInstanceInvocation(dotnetHelper) {
    //alert('we are here');
    dotnetHelper.invokeMethodAsync("IncrementCount");
    //alert('we are here2');
}
