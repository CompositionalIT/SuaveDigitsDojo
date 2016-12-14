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
    let ms = new MemoryStream()
    img.Save(ms, Imaging.ImageFormat.Bmp)
    ms.ToArray()
    |> Array.map int

let retrieveUrlFromQueryString (request:HttpRequest) =
    let url = request.queryParam "image"
    match url with
    | Choice1Of2 url ->
        let url = WebUtility.UrlDecode(url)
        Some(url)
    | Choice2Of2 _ -> None