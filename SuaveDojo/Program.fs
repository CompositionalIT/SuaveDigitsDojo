// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open ComputerVision
open Spam

let webApp classifier = choose [
    path "/classify" >=> request (fun r -> OK (classifyImage classifier r))
    path "/check-spam" >=> request (fun r -> OK (checkSpam r))
    RequestErrors.NOT_FOUND "Could not find a path which matches the provided route"
]

[<EntryPoint>]
let main argv = 
    printfn "Starting a new web server listening on port 8083"

    let model = retrieveModel ()

    let webApp = webApp model

    startWebServer defaultConfig webApp

    0 // return an integer exit code
