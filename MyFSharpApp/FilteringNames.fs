// For more information see https://aka.ms/fsharp-console-apps
let AllNames: string list = ["James";"Robert";"John";"William";"Michael";"David";"Richard"]

let NewList: string list = 
    List.filter (fun NAME -> NAME.Contains ("a", System.StringComparison.OriginalIgnoreCase)) AllNames

let FinalList :string =
   List.fold(fun acc NAME -> acc + NAME) ""   NewList

Printfn "%s" FinalList 