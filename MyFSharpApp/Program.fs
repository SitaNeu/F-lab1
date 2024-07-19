// For more information see https://aka.ms/fsharp-console-apps
let allNames: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

let newList: string list = 
    List.filter (fun name -> name.IndexOf("l", System.StringComparison.OrdinalIgnoreCase) >= 0) allNames

let finalList: string =
    List.fold (fun acc name -> acc + name + " " ) "" newList

printfn "%s" finalList

