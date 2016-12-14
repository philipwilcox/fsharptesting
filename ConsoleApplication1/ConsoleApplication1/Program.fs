// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

module HelloSquare

let square x = x * x

let isOdd x = x % 2 <> 0

[<EntryPoint>]
let main argv = 
    let n = 12
    printfn "%d squared is: %d!" n (square n)
    printfn "%d is odd: %b!" n (isOdd n)
    0 // return an integer exit code