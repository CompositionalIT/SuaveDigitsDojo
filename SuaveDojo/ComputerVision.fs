module ComputerVision

open Suave

type Model = int[] -> int

type Model = Image -> int

let retrieveModel () =
    //TODO: We need to build up a model here which is capable of classifying an image
    //We need to return a function which given an array of bytes returns an integer which it believes is the content of the byte array
    //Hint: Look at the classifier function we built this morning
    fun _ -> 0

let classifyImage (model:Model) (request:HttpRequest) : string =
    //TODO: Work your magic here and incorporate your trained model to work out the supplied image
    //Hint: Take a look in Helpers.fs for some additional help
    "Hello world"
