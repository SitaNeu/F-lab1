// For more information see https://aka.ms/fsharp-console-apps
let Trimming (Listing: string list) =
   Listing |> List.map (fun x -> x.Trim())


let list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let NoSpace = Trimming list

NoSpace |> List.iter (printfn "%s")
