let mutable x = 0
let mutable y = 0

let rec loop x y =
    if x > 10 then
        y
    else
        let z = x + y
        x <- x + 1
        y <- z
        loop x y

printf "%A" (loop 0 0)