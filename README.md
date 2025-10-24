# code-refactoring

Purpose
- A small refactoring exercise: make the codebase clearer, better named, and compile & run correctly.
- Do not add new features. Only refactor, rename, reorder, and fix bugs/compile errors, if needed change the architecture.

Quick start
1. Clone the repo
2. Remove the original git history and create your own repo:
   rm -rf .git
3. Work on the code, run builds often:
   dotnet build
   dotnet run

What to improve (priorities)
- Make code readable and consistent: rename poorly named variables, methods and classes.
- Fix incorrect or missing namespaces so files live in sensible namespaces.
- Resolve compiler/runtime errors (missing packages, wrong DI registrations, middleware order).
- Simplify confusing logic and remove dead code.
- Improve controller action return types.
- Ignore files that shouldn't be released to public ex. bin/obj.
- Ensure DbContext/EF usage is correct (DbSet access, async where appropriate).
- Add or fix unit tests if the project contains tests; keep tests focused on behavior, not new features.
- Be aware about what type of variable is being used.

Constraints
- DO NOT implement new functionality or features that change behavior.
- Changes must be limited to refactoring, bug fixes, naming, structure, documentation, tests.
- Keep commits small and focused. Explain intention in commit messages.

Code style and checks
- Use meaningful, English identifiers (avoid abbreviations unless well known).
- Keep namespaces aligned with folder structure.
- Prefer modern C# idioms (nullable reference types, expression-bodied members when clear).
- Run a build and tests before committing:
  dotnet build
  dotnet test

Common checks to run while refactoring
- dotnet build
- dotnet test
- dotnet format (optional, if installed)
- Inspect runtime by running locally: dotnet run

Submission
- Push your cleaned repo to your own remote.