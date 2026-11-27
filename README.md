# Portfolio

A personal portfolio built with Blazor WebAssembly on .NET 10. It is a single page with an introduction, work experience, and a project list loaded from JSON. It is published on GitHub Pages.

## Run locally

Install the .NET 10 SDK, then run the client project:

```sh
dotnet run --project portfolio.Client
```

Open the local URL printed by `dotnet run`.

## Checks

Run the portfolio tests and build from the repository root:

```sh
dotnet test portfolio.sln --configuration Release
```

## Update the project list

Edit [`portfolio.Client/wwwroot/data/projects.json`](portfolio.Client/wwwroot/data/projects.json). Each entry supports a title, description, technology list, demo link, and source repository link. Leave a link empty when that destination is not available.

## Deployment

The site is hosted at [qambershah.github.io/portfolio](https://qambershah.github.io/portfolio). Pull requests targeting `main` run the portfolio tests and build with .NET 10. After changes are merged, GitHub Actions reruns the tests, publishes the Blazor WebAssembly output, and deploys it to GitHub Pages. Set the repository's Pages publishing source to **GitHub Actions**.

## License

MIT
