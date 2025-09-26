# DatingApp

> A full-stack dating application built with **Angular (TypeScript)** for the frontend and **.NET Core Web API** for the backend.

---

## Table of Contents

- [About](#about)  
- [Features](#features)  
- [Tech Stack](#tech-stack)  
- [Architecture](#architecture)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Installation](#installation)  
  - [Configuration](#configuration)  
  - [Running the Application](#running-the-application)  
- [Usage](#usage)  
- [API Endpoints](#api-endpoints)  
- [Database Schema](#database-schema)  
- [Testing](#testing)  
- [Deployment](#deployment)  
- [Roadmap](#roadmap)  
- [Contributing](#contributing)  
- [License](#license)  

---

## About

DatingApp is a modern web application that allows users to:

- Create accounts & manage profiles  
- Browse and like other users  
- Match with compatible users  
- Chat in real-time  
- Receive notifications  

It’s a **full-stack demo project** designed to showcase a complete Angular + .NET Core setup with authentication, data persistence, and real-time messaging.

---

## Features

- 🔐 **Authentication & Authorization** (JWT)  
- 👤 **Profile Management** (photos, bios, preferences)  
- 💘 **Matchmaking** (like, dislike, match detection)  
- 💬 **Real-time Chat** (SignalR)  
- 📸 **Photo Uploads**  
- 🔎 **Filtering & Searching**  
- 📱 **Responsive Angular UI**  

---

## Tech Stack

| Layer        | Technology |
|--------------|------------|
| **Frontend** | Angular 17+, TypeScript, RxJS, Bootstrap/Tailwind |
| **Backend**  | .NET 8 Web API, Entity Framework Core, SignalR |
| **Database** | SQL Server / SQLite (for local dev) |
| **Auth**     | JWT Bearer Tokens |
| **Build/Deploy** | Docker, GitHub Actions (optional) |

---

# Client

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 21.0.0-next.3.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Karma](https://karma-runner.github.io) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
