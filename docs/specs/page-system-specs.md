# Page navigation system specification

- - -

# Base features

- Stack of previously shown pages that will allow to easily navigate back
- Page's view model can be only requested with identifier (probably enum)
- Due to how avalonia works "MainViewModel" has to be injected into viewmodel of a page.
Injected view model exposes two methods that can be used to naivgate between pages.
- Page's view model has to be derived from `PageViewModel`.
- Page's view has to be derived from `PageView`.

# Extra features
- Source generator 
  - creating partial boiler plate classes for view and view models
  - creates identifier for the page
