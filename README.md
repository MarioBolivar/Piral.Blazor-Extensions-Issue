- [Piral.Blazor-Extensions-Issue](#piralblazor-extensions-issue)
- [Bug Report](#bug-report)
  - [Environment Details and Version](#environment-details-and-version)
- [Description](#description)
- [Steps to Reproduce](#steps-to-reproduce)
  - [Expected behavior](#expected-behavior)
  - [Actual behavior](#actual-behavior)
  - [Supporting Images](#supporting-images)
    - [Two-Layers:](#two-layers)
    - [Three Layers:](#three-layers)
    - [Four-Layers:](#four-layers)


# Piral.Blazor-Extensions-Issue
This repo reproduces a Piral.Blazor `<Extension/>` duplication issue

# Bug Report
## Environment Details and Version
OS: Windows 10 version 22H2 (Build 19045.2728)
.NET 6
Piral.Blazor versions
- Piral.Blazor.DevServer 6.0.7
- Piral.Blazor.Utils 6.0.7
- Piral.Blazor.Tools 6.0.7
Browser: Chrome Version 111.0.5563.147

# Description
There currently exists an issue with Piral Blazor Extensions `<Extension/>` where nested extension components are duplicating exponentially as the number of nested layers grows. This is causing runtime issues where pages and components are incorrectly rendering.

# Steps to Reproduce
- Open sample Blazor pilet repo (https://github.com/MarioBolivar/Piral.Blazor-Extensions-Issue) with reproduction setup and run with debugging (F5) through the default IIS Express profile
- Navigate to `/extensionsissue`
- By default, only one nested extension component is enabled. You can uncomment Nested Extensions C-D to see the problem exacerbate.

## Expected behavior
When registering nested piral blazor extensions `<Extension/>`, these extensions should render correctly within one another.

## Actual behavior
When registering nested piral blazor extensions `<Extension/>`, these extensions render incorrectly and are duplicated. This issue is exacerbated as the number of nested extensions/layers grows.

## Supporting Images
**Note: If images do not render correctly, you can find them in this repo under ./Supporting Images/**
### Two-Layers:
![Two-Layers](./Supporting%20Images/Two-Layers.png?raw=true "Two Layers")

### Three Layers:
![Three-Layers](./Supporting%20Images/Three-Layers.png?raw=true "Three Layers")

### Four-Layers:
![Four-Layers](./Supporting%20Images/Four-Layers.png?raw=true "Four Layers")