# Repository Instructions

Read `README.md` and the applicable documents under `docs/` before changing behavior. `docs/PROJECT_SPEC.md`, `docs/ARCHITECTURE.md`, `docs/DECISIONS.md`, and `docs/plans/STATUS_LAMP_PLAN.md` are current authority. Files under `docs/history/` are historical context only.

Keep changes within the small StatusLamp scope and follow the existing ViewModel and `ICommand` patterns.

Use these validation commands from the repository root:

```powershell
dotnet build StatusLamp.sln
dotnet test tests\StatusLamp.Tests\StatusLamp.Tests.csproj
csharpier check .
git diff --check
```
