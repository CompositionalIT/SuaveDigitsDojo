module ComputerVision

open Suave

type Image = byte []

type Model = Image -> int

let retrieveModel () =
    fun _ -> 0

let classifyImage (model:Model) (request:HttpRequest) : string =
    //TODO: Work your magic here and incorporate your trained model to work out the supplied image
    //Hint: Take a look in Helpers.fs for some additional help
    "Hello world"
