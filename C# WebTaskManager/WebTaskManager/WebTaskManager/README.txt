WebTaskManager App
Dies ist ein einfaches Projekt für einen Task Manager, der in C# mit ASP.NET Core entwickelt wurde. Die Anwendung ermöglicht es, Aufgaben zu erstellen, zu verwalten, als erledigt zu markieren und zu löschen. Die Daten werden während der Laufzeit in einer In-Memory-Datenbank gespeichert, was das Projekt ideal für Demonstrationszwecke macht.

Funktionen
Aufgaben hinzufügen: Titel, Beschreibung, Kategorie und Fälligkeitsdatum angeben.
Aufgaben anzeigen: Liste der Aufgaben in einer übersichtlichen Tabelle.
Aufgaben als erledigt markieren: Status von Aufgaben ändern (Erledigt/Offen).
Aufgaben löschen: Entfernt Aufgaben direkt aus der Übersicht.

Verzeichnisstruktur

WebTaskManager/
├── Controllers/
│   └── TaskController.cs
├── Models/
│   └── TaskModel.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml
│   ├── Shared/
│   │   └── _Layout.cshtml
├── Data/
│   └── AppDbContext.cs
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
├── appsettings.json
├── Program.cs
└── WebTaskManager.csproj

Voraussetzungen

.NET 6.0 SDK oder höher
Visual Studio 2022 oder höher

Benötigte NuGet-Pakete
Installiere die folgenden Pakete, um sicherzustellen, dass alle Abhängigkeiten korrekt aufgelöst werden:

Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.InMemory
Microsoft.EntityFrameworkCore.InMemory
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Ermöglicht die dynamische Aktualisierung von Razor Views während der Entwicklung:
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Microsoft.Extensions.Logging.Console
Microsoft.Extensions.Logging.Console

Installation
Projekt in Visual Studio öffnen:

Öffnen Sie das Projekt WebTaskManager.csproj in Visual Studio.

NuGet-Pakete installieren:
Installiere die oben genannten Pakete über die Paket-Manager-Konsole oder den NuGet-Paket-Manager.

Projekt erstellen und starten:
Erstellen Sie das Projekt in Visual Studio: Build > Projektmappe erstellen.
Starten Sie die Anwendung mit F5 oder klicken Sie auf Debuggen > Starten.

Hinweis
Dieses Projekt ist ein Testprogramm und dient der Demonstration von Programmierfähigkeiten. Die gesamte Entwicklung hat ca. 90 Minuten gedauert und umfasst grundlegende Funktionen eines Task Managers.
