# Unexpected Behavior of Mutable Variables in Recursive F# Function

This repository demonstrates a subtle bug related to the use of mutable variables within a recursive function in F#.  The `loop` function, while seemingly straightforward, produces an unexpected output due to the way mutable variables are handled during recursive calls. The solution shows how to refactor the code to produce the intended results.

## Bug Description

The `bug.fs` file contains a recursive function that uses mutable variables (`x` and `y`). The intention is to calculate a sequence of numbers, but the mutable updates within the recursive call lead to unexpected results.

## Solution

The `bugSolution.fs` file presents a corrected version of the function. The solution avoids mutable variables and leverages immutability, a core strength of F#, resulting in correct and predictable behavior.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in your F# development environment.
3. Compile and run the code; observe the unexpected output.
4. Repeat with `bugSolution.fs` to see the correct output.

## Lessons Learned

This example highlights the importance of carefully considering the use of mutable variables in recursive functions. While mutable variables can be convenient at times, favoring immutability is often a safer and more predictable approach, particularly in functional programming languages like F#.