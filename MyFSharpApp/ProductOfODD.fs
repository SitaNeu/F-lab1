// For more information see https://aka.ms/fsharp-console-apps
let  Product (n:int)=
    let rec helper (current:int) (acc:int)=
      if current <= 0 then acc
      else helper (current-2) (acc*current)
    helper n 1

let total = Product 9
printfn "The product is: %d" total      

