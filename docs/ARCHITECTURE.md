# Architecture

- WPF owns presentation and binding.
- The ViewModel owns application state and state-changing behavior.
- User actions are exposed through `ICommand`.
- Code-behind is limited to view initialization.
- ViewModel tests exercise behavior without launching the WPF window.
- A service layer requires a demonstrated need; none exists in the current scope.
- Do not introduce a generalized state framework for the existing scope.
