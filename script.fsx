let s = [1;2] @ [3; 4]

printfn "second code line: %s" (s.ToString())

type Person = {name: string; age: int}
let bob1 = { name ="Bob"; age = 55 }
let bob2 = { bob1 with age = 56 }

printfn "person bob1: %s" (bob1.ToString())

type Note = A | B | Ass

type Sound = Rest | Tone of Note * int
let rest = Rest
let tone = Tone(A, 10)
let sound = A

open System
open System.IO     
Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

if not (File.Exists "paket.exe") then
    let url = "https://github.com/fsprojects/Paket/releases/download/5.195.1/paket.exe"
    use wc = new Net.WebClient()
    let tmp = Path.GetTempFileName()
    wc.DownloadFile(url, tmp)
    File.Move(tmp,Path.GetFileName url)

// Step 1. Resolve and install the packages     
#r "paket.exe"     
Paket.Dependencies.Install """
source https://nuget.org/api/v2

nuget Suave
nuget FSharp.Data
nuget FSharp.Charting
""";;

#r "./packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"
