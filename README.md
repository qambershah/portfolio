# 🧑‍💻 Portfolio Site

This is a professional portfolio site built using **Blazor WebAssembly** with **MudBlazor** for UI components. It's deployed via **GitHub Pages** using a custom **CI/CD pipeline** powered by **GitHub Actions**.

## 🚀 Features

- **Blazor WebAssembly** frontend
- **MudBlazor** component library for modern UI/UX
- Responsive layout with dark/light theme support
- Project showcase powered by `projects.json`
- Hosted on **GitHub Pages**
- Automated deployments with GitHub Actions

## 🔗 Live Site

👉 [https://qambershah.github.io/portfolio](https://qambershah.github.io/portfolio)

## 🧰 Tech Stack

- **Blazor WASM (.NET 8)**
- **MudBlazor**
- **GitHub Pages**
- **GitHub Actions (CI/CD)**

## 📂 Project Structure

```text
portfolio/
├── portfolio.Client         # Blazor WASM frontend using MudBlazor
├── portfolio                # Blazor Server host (entry point for dev/deploy)
├── wwwroot/                 # Static assets served by the client project
├── .github/workflows/       # GitHub Actions for automated CI/CD
├── projects.json            # Dynamic content source for project listings
└── README.md                # Project documentation
```

## 🧪 Local Development

```bash
dotnet run --project portfolio
```

## 📦 Deployment

This project is deployed automatically using a GitHub Actions workflow located in `.github/workflows/`. 
Any changes pushed to the `main` branch will trigger a deployment to GitHub Pages.

## 🧾 License

MIT