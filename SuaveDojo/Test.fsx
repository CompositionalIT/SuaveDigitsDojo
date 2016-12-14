open System.Net

let classifyImage (url:string) =
    let url = WebUtility.UrlEncode(url)
    let query = sprintf "http://localhost:8083/classify?image=%s" url
    let wc = new WebClient()
    wc.DownloadString(query)

//TODO: Now call your web API and try and classify an image at a given URL
classifyImage "http://test.com/image.jpg"