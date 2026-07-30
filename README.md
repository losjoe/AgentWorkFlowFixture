# StatusLamp

StatusLamp is a small WPF application representing one local binary equipment-status lamp. It starts off, displays `0` on red, and toggles to `1` on green.

The solution targets `net9.0-windows` and pins the installed .NET SDK `9.0.316` through `global.json`.

## Build and test

Run from the repository root:

```powershell
dotnet build StatusLamp.sln
dotnet test tests\StatusLamp.Tests\StatusLamp.Tests.csproj
```

Run the application with:

```powershell
dotnet run --project src\StatusLamp.Wpf\StatusLamp.Wpf.csproj
```

## Project documentation

Current product, architecture, development, testing, and decision records are under `docs/`. The active plan is `docs/plans/STATUS_LAMP_PLAN.md`.

This repository intentionally has a small current scope. Documents under `docs/history/` describe superseded ideas and are not current implementation authority.
