<p align="center">
  <img src="wwwroot/AspGoatLogo-Github.png" alt="AspGoat Logo" height="500" width="1000"/>
</p>

<h1 align="center">🐐 AspGoat</h1>

<p align="center">
  <i>An intentionally vulnerable ASP.NET Core web application for learning and practicing Web Application Security.</i>
</p>

<p align="center">
  <a href="https://github.com/Soham7-dev/AspGoat/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Soham7-dev/AspGoat?style=flat-square&color=blue" alt="license"/>
  </a>
  <a href="https://github.com/Soham7-dev/AspGoat/stargazers">
    <img src="https://img.shields.io/github/stars/Soham7-dev/AspGoat?style=flat-square&color=yellow" alt="stars"/>
  </a>
  <a href="https://github.com/Soham7-dev/AspGoat/network/members">
    <img src="https://img.shields.io/github/forks/Soham7-dev/AspGoat?style=flat-square&color=green" alt="forks"/>
  </a>
  <a href="https://github.com/Soham7-dev/AspGoat/actions">
    <img src="https://img.shields.io/github/actions/workflow/status/Soham7-dev/AspGoat/dotnet.yml?style=flat-square" alt="ci-status"/>
  </a>
  <a href="https://hub.docker.com/r/YOUR_DOCKERHUB_USERNAME/aspgoat">
    <img src="https://img.shields.io/docker/pulls/YOUR_DOCKERHUB_USERNAME/aspgoat?style=flat-square&logo=docker" alt="docker pulls"/>
  </a>
</p>

---

## 📖 About AspGoat

**AspGoat** is an intentionally vulnerable **ASP.NET Core** application that helps Security Engineers and Developers analyze and mitigate common web application vulnerabilities. 
It includes the **OWASP Top 10** and beyond, providing hands-on Application Security challenges.

⚠️ **Disclaimer**: This project is for **educational purposes only**. Do **not** deploy to production environments.  

---

## ✨ Features

- 🐞 Intentionally vulnerable ASP.NET Core MVC app  
- 📚 Hands-on labs for:
  - **Cross-Site Scripting (XSS)**
  - **Cross-Site Request Forgery (CSRF)**
  - **SQL Injection (SQLi)**
  - **XML External Entity (XXE)**
  - **Local File Inclusion (LFI)**
  - **Remote Code Execution (RCE)**
  - **Unrestricted File Upload**
  - **Information Disclosure**
  - **Broken Authentication**
  - **Server-Side Request Forgery (SSRF)**
  - **Insecure Direct Object Reference (IDOR)**
  - **Insecure Deserialization**
  - **Command Injection**
  - 🛡️ **Secure vs Insecure coding snippets**  
  - 🐳 **Ready-to-run Docker setup**  

---

## 🪛 Installation

### Using Docker (recommended)

### Clone the repository

```git clone https://github.com/Soham7-dev/AspGoat.git```

```cd AspGoat```

### Build the image

```docker build -t aspgoat .```

### Run the container

```docker run --rm -p 8000:8000 aspgoat```

### Access the app

```http://localhost:8000```


---


### Using .NET SDK

Download and install the **.NET SDK 8.0 (LTS)** from:  
👉 [.NET-Download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  

*(The SDK includes the runtime, so this is all you need to build and run AspGoat from source.)*

### Clone the repository

```git clone https://github.com/Soham7-dev/AspGoat.git```

```cd AspGoat```

### Restore Dependencies

```dotnet restore```

### Run the app

```dotnet run```

### Access the app

```http://localhost:5073```

