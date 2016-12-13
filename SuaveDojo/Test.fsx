open System.Net

let classifyImage (url:string) =
    let url = WebUtility.UrlEncode(url)
    let query = sprintf "http://localhost:8083/classify?image=%s" url
    let wc = new WebClient()
    wc.DownloadString(query)

classifyImage "http://test.com/image.jpg"