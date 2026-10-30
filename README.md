# AssessmentRepo

Short C# exercises of the kind found in technical assessments and coding interviews, plus a couple of LeetCode problems.
Each exercise is a small, independent console project.

## Assessment exercises (`C-Sharp`)

| Exercise | Source | Description | Complexity |
|---|---|---|---|
| closestToZero | [Program.cs](C-Sharp/closestToZero/Program.cs) | Returns the integer closest to zero, preferring the positive value on a tie and `0` for a null or empty array (LINQ `OrderBy(Math.Abs).ThenByDescending`). | O(n log n) time |
| stringWithParenthesesBrackets | [Program.cs](C-Sharp/stringWithParenthesesBrackets/Program.cs) | Checks that `()` and `[]` in a string are balanced and correctly nested, using a stack. | O(n) time, O(n) space |
| GetSuperCustomers | [Program.cs](C-Sharp/GetSuperCustomers/Program.cs) | LINQ query returning customers whose orders total more than 100; the demo builds the query before adding orders, which shows deferred execution. | O(n) time |
| equal21 | [Program.cs](C-Sharp/equal21/Program.cs) | `Test(i, j)` returns true when `i` is 1, `j` is 1, or `i + j` equals 1. | O(1) |
| commit | [Program.cs](C-Sharp/commit/Program.cs) | Runs a service on a connection with commit on success, rollback on failure and close in every case; the demo service throws to exercise the error path. | - |
| 2Solution | [Program.cs](C-Sharp/2Solution/Program.cs) | Class-design question: modelling something that can fly with abstract `AirPlane`/`Bird` classes; an interface-based version is left commented out. | - |

## LeetCode (`leetCode/C-sharp_leet`)

| Problem | Source | Description | Complexity |
|---|---|---|---|
| Two Sum | [Program.cs](leetCode/C-sharp_leet/twoSum/Program.cs) | Finds the indices of two numbers adding up to a target with a single pass over a value-to-index dictionary. | O(n) time, O(n) space |
| Add Two Numbers | [Program.cs](leetCode/C-sharp_leet/add2Num/Program.cs) | Adds two numbers stored as reversed-digit linked lists, propagating the carry. | O(max(m, n)) time |

## How to run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (7.0 or newer). Every folder contains its own `.csproj`; there is no solution file.

```bash
dotnet run --project C-Sharp/stringWithParenthesesBrackets
dotnet run --project leetCode/C-sharp_leet/twoSum
```

The projects target .NET 7, which is out of support. If only a newer runtime is installed, prefix the command with
`DOTNET_ROLL_FORWARD=Major`. You can also open any `.csproj` in Visual Studio, Rider or VS Code.

Note: the demo service in `commit` always throws, so that program ends with an unhandled exception after printing `Close`; `2Solution` prints nothing.

## Contributing / suggestions

Suggestions and alternative solutions are welcome through an issue or a pull request.
