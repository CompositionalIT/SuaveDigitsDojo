module Helpers

open System.Net
open System.Drawing
open System.IO
open Suave

let downloadImage (url:string) =
    let wc = new WebClient()
    let image = wc.DownloadData(url)
    let ms = new MemoryStream(image)
    let img = new Bitmap(ms)
    new Bitmap(img, 28, 28)

let convertImageToBytes (img:Bitmap) =
    [| for y in 0..27 do for x in 0..27 do yield img.GetPixel(x, y) |]
    |> Array.map (fun c -> (0.3 * (float c.R) + 0.59 * (float c.G) + 0.11 * (float c.B)) |> int)

let retrieveUrlFromQueryString (request:HttpRequest) =
    let url = request.queryParam "image"
    match url with
    | Choice1Of2 url ->
        let url = WebUtility.UrlDecode(url)
        Some(url)
    | Choice2Of2 _ -> None