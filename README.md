<p align="center">
  <a href="https://github.com/NickeManarin/ScreenToGif" target="_blank">
    <img align="center" alt="ScreenToGif Logo" src="https://nickemanarin.github.io/ScreenToGif-Website/logos/ms-icon-144x144.png" width="96" height="96" />
  </a>
</p>

<h1 align="center">
  ScreenToGif — Tailored Edition 🎬
</h1>

<p align="center">
  A streamlined, workflow-optimized edition of <strong>ScreenToGif</strong> designed for standardized visual software documentation.
</p>

<p align="center">
  <img alt="Self-Contained win-x64" src="https://img.shields.io/badge/.NET%209-Self--Contained%20(win--x64)-512BD4?logo=dotnet" />
  <img alt="Platform Windows" src="https://img.shields.io/badge/Platform-Windows%20x64-0078D6?logo=windows" />
  <a href="LICENSE.txt">
    <img alt="License MS-PL" src="https://img.shields.io/badge/License-MS--PL-brightgreen.svg" />
  </a>
  <a href="https://github.com/NickeManarin/ScreenToGif" target="_blank">
    <img alt="Upstream NickeManarin/ScreenToGif" src="https://img.shields.io/badge/Upstream-NickeManarin%2FScreenToGif-orange?logo=github" />
  </a>
</p>

<p align="center">
  🌐 <strong>Language / Sprache:</strong> <a href="#-english">English</a> | <a href="#-deutsch">Deutsch</a>
</p>

---

<a name="-english"></a>
## 🇬🇧 English

### 1. About This Project
**ScreenToGif** is a widely acclaimed open-source screen recording and animated GIF editor for Windows, originally created and maintained by **Nicke Manarin**.

The **Tailored Edition** is a specialized fork crafted specifically for creating consistent, high-quality, and repeatable visual software documentation. Rather than offering an overwhelming array of general-purpose media tools, this edition tailors the user interface and functionality directly to an established documentation pipeline.

---

### 2. Purpose of the Fork
In this fork, features that do not align with our visual documentation workflow or pipeline have been intentionally removed from the user interface. Navigation tabs have been reorganized into a linear, sequential process, and purpose-built functions were added to streamline routine documentation tasks:

* **Distraction-Free UI:** Unused options, recording modes, and background modules have been hidden to prevent misconfigurations and eliminate clutter.
* **Strict Standardization:** 
  * **Progress Bar:** Appearance and animation behavior are standardized and locked to guarantee a unified look across all documentation assets.
  * **Left-Click Highlight:** Visual styling and color for mouse clicks are standardized and locked.
* **Supported Export Formats:**
  * **Poster / Single Frames:** Saved exclusively as **JPEG**, **PNG**, or **GIF**.
  * **Screen Recording Animation:** Produced exclusively as **Animated GIF** (`.gif`).

---

### 3. The 7-Step Documentation Workflow ("Docu Process")
The main menu has been transformed into a guided ribbon called **Docu Process**, featuring seven numbered steps (`>> 1 >>`, `>> 2 >>`, etc.) styled in accent color (`#111B42`):

1. **`1 >> Save Project`** — Immediately creates an initial safety backup of the raw recording. If editing errors occur later, the original recording can be restored at any time.
2. **`2 >> Save Poster`** — Selects and exports a key frame from the timeline as a static image (Cover/Poster in JPG, PNG, or GIF). This poster serves as the static preview image on documentation websites before the animation is triggered.
3. **`3 >> Edit Timeline`** — Jumps directly to the **Actions** tab to trim, cut, and adjust frames. Here, you also apply a standardized **Start Delay** and **End Delay** buffer.
4. **`4 >> Save Project`** — Intermediate save after trimming is complete. This establishes a clean checkpoint before applying permanent visual overlays.
5. **`5 >> Add Progress Bar`** — Applies the standardized progress bar indicator to the animation with one click.
6. **`6 >> Add Left Click Highlight`** — Applies the standardized highlight effect for all left mouse clicks.
7. **`7 >> Save Animated GIF`** — Opens the export sidebar with pre-tuned encoding presets for the final animated GIF file.

---

### 4. Detailed Summary of Changes (Compared to Upstream)

#### 1. Branding & Identity
* **Window & Overlay Titles:** Updated to `ScreenToGif 2.43.2 Tailored Edition` across the Editor, Startup launcher, and Recorder overlay.
* **Startup Launcher:** Restored direct one-click access to the **Editor** while keeping the screen recorder front and center.
* **About & Credits:** Dedicated settings page giving full recognition to the original author (*Nicke Manarin*) and the MS-PL license, while outlining the tailored documentation modifications.

#### 2. Simplified Interface & Decluttering
* **Options Dialog:** Hidden irrelevant categories (*Application, Recorder, Editor, Tasks, Storage, Cloud, Extras*) to maintain a focused configuration interface.
* **Extras Menu:** Removed *Feedback* and *Troubleshoot* dialogs.
* **Shortcuts:** Cleaned up unused global shortcut registrations (*Webcam recorder, Board recorder, Options*).
* **Focused Recording:** Hidden non-documentation tools (webcam recorder, whiteboard sketcher) from primary screens.

#### 3. Guided 7-Step Documentation Process ("Docu Process")
* Renamed the original *File* tab to **Docu Process**.
* Organized the **Process Steps** container into seven sequential, visually centered steps with chevrons (`>> X >>`) in theme color `#111B42`.

#### 4. Restructured "Actions" Tab (formerly "Home")
* **Integrated Playback:** Moved *Playback* and *Playback Options* directly in front of editing tools.
* **Frames Container:**
  * Added **Delete All Previous** (deletes all frames prior to current frame).
  * Added **Delete All Next** (deletes all frames after current frame).
  * Added **Delay at Start / Buffer Tool:** Dropdown providing `0s`, `0.25s`, `0.5s`, `0.75s` (default), and `1.0s`. Automatically calculates and duplicates first/last frames based on frame delay to ensure smooth reading pauses and looping; cleanly removes and resets previous buffers on change.
* **Layout Order:** `Frames` $\rightarrow$ `Clipboard` $\rightarrow$ `Action Stack` (Undo/Redo) $\rightarrow$ `Zoom`.

#### 5. Enhanced Export & Storage Functions
* **Right-Click Single Frame Export:** Restored the ability to right-click any frame in the bottom filmstrip and export it immediately (defaulting to JPG, with PNG and GIF support).
* **Dedicated "Save Poster" Sidebar:** Provides a dedicated panel to export the current frame with full resolution and saved destination path history.
* **Pre-Tuned Presets:** Built-in presets for quantizers, color palettes, and file paths eliminate manual encoder setup.

#### 6. Stability & Binary Size Optimization
* **Race-Condition & Deadlock Fix:** Resolved an upstream timing issue in the recorder where double-stopping capture caused UI freezes and application hangs.
* **Export Panel Guard:** Guarded against recursive save invocations in the sidebar.
* **Self-Contained Single-File Binary:** Built as a standalone Self-Contained x64 executable with the full .NET 9 Runtime embedded. End users can launch the application immediately without installing any external runtime or dependencies.

---

### 5. Requirements & Running
* **Operating System:** Windows 10 / 11 (64-Bit)
* **Runtime:** Fully self-contained — **No separate .NET Runtime installation required.**
* **Executable:** Run `ScreenToGif.exe` directly or build using `dotnet publish ScreenToGif/ScreenToGif.csproj /p:PublishProfile="Publish as x64"`.

---

### 6. Credits & License
* **Original Creator:** [Nicke Manarin](https://github.com/NickeManarin)
* **Original Project:** [https://github.com/NickeManarin/ScreenToGif](https://github.com/NickeManarin/ScreenToGif)
* **License:** Microsoft Public License ([MS-PL](LICENSE.txt)). All intellectual property and credit for the original codebase remain with Nicke Manarin and its open-source contributors.

---
---

<a name="-deutsch"></a>
## 🇩🇪 Deutsch

### 1. Über dieses Projekt
**ScreenToGif** ist ein bewährtes Open-Source-Werkzeug zur Bildschirmaufzeichnung und Bearbeitung von animierten GIFs für Windows, ursprünglich entwickelt und gepflegt von **Nicke Manarin**.

Die **Tailored Edition** ist ein spezialisierter Fork, der gezielt auf die Erstellung standardisierter, visueller Softwaredokumentationen angepasst wurde. Anstelle einer unübersichtlichen Fülle allgemeiner Medienwerkzeuge konzentriert sich diese Edition kompromisslos auf eine festgelegte Dokumentations-Pipeline.

---

### 2. Zweck und Konzept dieses Forks
Bei diesem Fork wurden Funktionen, die für den vorgesehenen Dokumentations-Workflow bzw. die definierte Pipeline nicht benötigt werden, gezielt aus der Benutzeroberfläche (Frontend) entfernt. Die Funktionsreiter wurden neu strukturiert und essenzielle Schritte ergänzt, um einen fehlerfreien, geführten Ablauf zu gewährleisten:

* **Fokussierte Benutzeroberfläche:** Nicht benötigte Optionen, Aufnahmemodi und Hintergrunddienste wurden ausgeblendet, um Fehlbedienungen auszuschließen und eine klare Struktur zu bieten.
* **Standardisierte Gestaltungselemente:**
  * **Progress Bar (Fortschrittsbalken):** Aussehen und Verhalten sind fest standardisiert und können vom Anwender nicht verändert werden, um eine einheitliche Corporate Identity über alle Dokumentationsinhalte sicherzustellen.
  * **Left-Click Highlight (Linksklick-Hervorhebung):** Farbe und Animationseffekt bei Mausklicks sind fest standardisiert und unveränderbar.
* **Zulässige Dateiformate:**
  * **Poster / Standbilder:** Ausschließlich **JPEG**, **PNG** und **GIF**.
  * **Aufnahmen / Animationen:** Ausschließlich **animierte GIFs** (`.gif`).

---

### 3. Der 7-Schritte-Dokumentationsprozess ("Docu Process")
Der Hauptreiter wurde in **Docu Process** umbenannt und enthält die Leiste **Process Steps** mit sieben aufeinander aufbauenden, nummerierten Schritten (`>> 1 >>`, `>> 2 >>`, usw.) in der Akzentfarbe (`#111B42`):

1. **`1 >> Save Project`** – Die eben getätigte Aufnahme wird als Erstes als Projektdatei abgespeichert. So kann der Rohzustand jederzeit wiederhergestellt werden, falls bei der Nachbearbeitung Fehler passieren.
2. **`2 >> Save Poster`** – Ein repräsentatives Frame wird aus der Timeline selektiert und als Standbild (Cover/Poster in JPG, PNG oder GIF) gespeichert. Dieses Poster dient später auf der Dokumentations-Website als Vorschaubild, über das das animierte GIF gestartet wird.
3. **`3 >> Edit Timeline`** – Wechselt direkt auf den Reiter **Actions**, um die Aufnahme zu schneiden (Frames trimmen/löschen) sowie einen standardisierten Start- und End-Puffer (**Start Delay / End Delay**) einzufügen.
4. **`4 >> Save Project`** – Erneutes Zwischenspeichern nach dem Schnitt. Dadurch entsteht ein stabiler Sicherungspunkt, bevor permanente visuelle Overlays aufgebracht werden.
5. **`5 >> Add Progress Bar`** – Fügt der Animation den vorkonfigurierten, standardisierten Fortschrittsbalken hinzu.
6. **`6 >> Add Left Click Highlight`** – Fügt die standardisierte Hervorhebung für alle Linksklicks hinzu.
7. **`7 >> Save Animated GIF`** – Öffnet die Speichern-Seitenleiste mit optimierten Standardwerten für das finale animierte GIF.

---

### 4. Detaillierte Übersicht aller Änderungen (im Vergleich zum Original)

#### 1. Branding & Identität
* **Fenstertitel & Overlay:** Einheitlich als `ScreenToGif 2.43.2 Tailored Edition` im Editor, im Recorder-Overlay und im Startfenster gekennzeichnet.
* **Startup-Fenster:** Startbildschirm aufgeräumt; Direktzugriff auf den **Editor** wiederhergestellt.
* **About & Credits:** Einstellungsseite vollständig überarbeitet. Sie würdigt den Originalautor (*Nicke Manarin*) und die MS-PL-Lizenz und dokumentiert die vorgenommenen Anpassungen für die Dokumentations-Pipeline.

#### 2. Vereinfachte Oberfläche & Entrümpelung
* **Optionen:** Nicht benötigte Kategorien (*Application, Recorder, Editor, Tasks, Storage, Cloud, Extras*) entfernt.
* **Extras-Menü:** *Feedback* und *Troubleshoot* entfernt.
* **Tastaturkürzel:** Nicht genutzte globale Shortcuts (*Webcam recorder, Board recorder, Options*) ausgeblendet.
* **Recorder:** Nicht genutzte Modi (Webcam- und Board-Recorder) aus den Hauptmenüs entfernt.

#### 3. Neuer geführter 7-Schritte-Dokumentationsprozess ("Docu Process")
* Der frühere Reiter *File* wurde in **Docu Process** umbenannt.
* Die Funktionsgruppe **Process Steps** führt den Anwender mit optisch hervorgehobenen Schrittnummern und Pfeilen (`>> X >>`) strukturiert durch alle 7 Phasen der GIF-Erstellung.

#### 4. Neu strukturierter Reiter "Actions" (früher "Home")
* **Playback & Playback Options:** Vor die Schnittwerkzeuge integriert.
* **Gruppe Frames:**
  * `Delete All Previous` (Alle Frames vor der aktuellen Markierung löschen).
  * `Delete All Next` (Alle Frames nach der aktuellen Markierung löschen).
  * **Neu:** `Delay at Start / Buffer`: Dropdown mit `0s`, `0.25s`, `0.5s`, `0.75s` *(Default)*, `1.0s`. Berechnet anhand der Frame-Verzögerung automatisch die benötigten Duplikate am Start und Ende für eine saubere Pause vor dem Loop; entfernt bei Neuwahl vorherige Puffer-Frames automatisch.
* **Ergonomische Anordnung:** `Frames` $\rightarrow$ `Clipboard` $\rightarrow$ `Action Stack` (Undo/Redo) $\rightarrow$ `Zoom`.

#### 5. Erweiterte Export- & Speicherfunktionen
* **Einzelbildexport per Rechtsklick:** Beliebige Frames im Filmstreifen können per Rechtsklick direkt als Datei exportiert werden (Standard: JPG, alternativ PNG/GIF).
* **Eigene "Save Poster"-Sidebar:** Eigene Seitenleiste zum verlustfreien Exportieren des ausgewählten Standbilds inklusive Pfad-Historie.
* **Vorkonfigurierte Presets:** Voreingestellte Quantisierer, Farbpaletten und Benennungsregeln machen manuelle Encodereinstellungen überflüssig.

#### 6. Stabilität & Dateigröße
* **Crash- & Deadlock-Prävention:** Behebung einer Race-Condition im Recorder, die beim Stoppen von Aufnahmen zu Deadlocks und Hängern führen konnte.
* **Sidebar-Absicherung:** Schutz vor rekursiven Speicheraufrufen bei mehrfachem Klick in der Sidebar.
* **Self-Contained Single-File Binary:** Als eigenständige, autarke Windows x64 Executable paketiert (.NET 9 Runtime ist direkt enthalten). Anwender können die Anwendung ohne vorherige .NET-Installation direkt starten.

---

### 5. Systemvoraussetzungen
* **Betriebssystem:** Windows 10 / 11 (64-Bit)
* **Laufzeitumgebung:** Vollständig autark (Self-Contained) — **keine separate .NET Runtime-Installation erforderlich.**
* **Ausführung:** `ScreenToGif.exe` direkt starten oder kompilieren mit `dotnet publish ScreenToGif/ScreenToGif.csproj /p:PublishProfile="Publish as x64"`.

---

### 6. Danksagung & Lizenz
* **Originalautor:** [Nicke Manarin](https://github.com/NickeManarin)
* **Originalprojekt:** [https://github.com/NickeManarin/ScreenToGif](https://github.com/NickeManarin/ScreenToGif)
* **Lizenz:** Microsoft Public License ([MS-PL](LICENSE.txt)). Sämtliche Urheber- und Anerkennungsrechte an der Originalsoftware verbleiben vollumfänglich bei Nicke Manarin und der Open-Source-Community.
