<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-6%2B-512BD4?logo=dotnet&logoColor=white">
  <img alt="ASP.NET Core MVC" src="https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white">
  <img alt="EF Core" src="https://img.shields.io/badge/EF%20Core-InMemory-512BD4?logo=database&logoColor=white">
  <img alt="License" src="https://img.shields.io/badge/License-MIT-lightgrey.svg">
</p>

# WebTaskManager App

Einfacher **Task Manager** in **C# / ASP.NET Core (MVC)**.  
Aufgaben **erstellen**, **anzeigen**, **als erledigt markieren** und **löschen**.  
Daten werden in einer **In-Memory-Datenbank (EF Core InMemory)** gehalten – ideal für Demos und Lernzwecke.

---

## ✨ Funktionen

- **Aufgaben hinzufügen**: Titel, Beschreibung, Kategorie, Fälligkeitsdatum  
- **Aufgaben anzeigen**: Übersichtliche Tabelle/Liste  
- **Status ändern**: Aufgaben als *Erledigt* / *Offen* markieren  
- **Aufgaben löschen**: Entfernen direkt aus der Übersicht

---

## 🚀 Quickstart

### Variante A: .NET CLI
```bash
# Aus dem Projektordner starten
dotnet restore
dotnet build
dotnet run
```
- Standard-URL (Dev): `https://localhost:7043` oder `http://localhost:5246` (kann variieren, s. Konsole)

### Variante B: Visual Studio
1) `WebTaskManager.csproj` öffnen  
2) **Build** → *Projektmappe erstellen*  
3) **F5** (Debuggen → Starten)

---

## 📦 Voraussetzungen

- **.NET 6.0 SDK** oder höher  
- (Optional) **Visual Studio 2022** oder höher mit „ASP.NET und Webentwicklung“

---

## 📚 Benötigte Pakete

> Du kannst die Pakete via **NuGet UI**, **Paket-Manager-Konsole** oder **.NET CLI** installieren.

**.NET CLI (empfohlen):**
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
dotnet add package Microsoft.Extensions.Logging.Console
```

**Paket-Manager-Konsole (Alternative):**
```ps1
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.InMemory
Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Install-Package Microsoft.Extensions.Logging.Console
```

> *Razor Runtime Comp*
