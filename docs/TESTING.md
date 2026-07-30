# Testing

- xUnit is the test framework.
- Prefer focused ViewModel tests for application behavior.
- Run the narrowest relevant tests before the complete test project.
- Ordinary ViewModel behavior does not require WPF UI automation.
- Use source inspection or a small manual smoke check for bindings and visual confirmation when appropriate.
- Do not weaken existing assertions to make an implementation pass.
