// For more information see https://aka.ms/fsharp-console-apps
let rec Product acc = function
    | [] -> acc
    | x::xs -> Product (acc * x) xs

let ProductList = [1; 2; 3; 4; 5]
let result = Product 1 ProductList
printfn "Product: %A" result
