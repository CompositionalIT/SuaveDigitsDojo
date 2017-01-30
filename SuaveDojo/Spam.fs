module Spam

open Suave

let checkSpam (request:HttpRequest) =
    "Not spam."