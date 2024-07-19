// For more information see https://aka.ms/fsharp-console-apps

let sequence = seq { 1 .. 700 }

let myNumber = Seq.toList sequence

let filtered = List.filter (fun x -> x % 7 = 0 && x % 5 = 0) myNumber

let sumUp = List.fold (+) 0 filtered

printfn "%A" filtered

printfn "The sum is: %d" sumUp
