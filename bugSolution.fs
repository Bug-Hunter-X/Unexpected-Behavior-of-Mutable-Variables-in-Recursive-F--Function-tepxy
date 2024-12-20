let rec loop x y =
    if x > 10 then
        y
    else
        loop (x + 1) (x + y)

printf "%A" (loop 0 0)