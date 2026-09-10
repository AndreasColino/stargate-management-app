# Stargate Management Application (SAE 24)

---

## 🇫🇷 Français

### À propos du projet

Application développée en C# avec Windows Forms et SQLite, permettant de gérer et d'explorer l'univers Stargate (missions, équipes, planètes, civilisations extraterrestres et rapports). Projet académique de groupe réalisé dans le cadre de la SAE 24 (IUT Robert Schuman - Université de Strasbourg) ; ce dépôt se focalise sur les modules et composants développés et intégrés personnellement pour le rendu final. *(Faute de temps et de moyens inhérents à un projet universitaire, certaines images de fond ont été générées par IA).*

### Fonctionnalités et Contributions principales

- **Création de nouvelle mission :** Interface dédiée à l'enregistrement et à la configuration de nouvelles missions d'exploration.
- **Sécurité & Authentification :** Espace sécurisé pour l'ajout de nouvelles missions, protégé par un hachage des mots de passe avec l'algorithme BCrypt.
- **Intégration de l'infrastructure globale :** Assemblage des différents composants (UserControls, formulaires et bases de données) du projet de groupe.

### Technologies et Outils

- **Langage :** C# (.NET Framework 4.7.2)
- **Interface :** Windows Forms, UserControls
- **Base de données :** SQLite (`System.Data.SQLite`)
- **Sécurité :** BCrypt.Net-Core
- **Contrôle de version :** Git / GitHub

---

## 🇬🇧 English

### About the project

A desktop application developed in C# with Windows Forms and SQLite, designed to manage and explore the Stargate universe (missions, teams, planets, extraterrestrial civilizations and reports). Academic group project built as part of SAE 24 (IUT Robert Schuman - University of Strasbourg); this repository focuses on the modules and components personally developed and integrated for the final submission. *(Note: Due to time and resource constraints typical of a university project, some background images were generated using AI).*

### Main Features & Contributions

- **New Mission Creation:** Dedicated interface for recording and setting up new exploration missions.
- **Security & Authentication:** Secure authorization layer for adding new missions using BCrypt password hashing.
- **Group Project Integration:** Assembly and refinement of core components, user controls, and data layers developed across the team.

### Technologies & Tools

- **Language:** C# (.NET Framework 4.7.2)
- **UI:** Windows Forms, custom UserControls
- **Database:** SQLite (`System.Data.SQLite`)
- **Security:** BCrypt.Net-Core
- **Version Control:** Git / GitHub

---

## 📦 Installation & Setup

### 🇫🇷 Français

#### Option 1 : Téléchargement direct (Recommandé - Windows)

*Prérequis : Windows 10 ou 11 avec .NET Framework 4.7.2 (intégré par défaut).*

1. Rends-toi dans la section [**Releases**](https://github.com/AndreasColino/stargate-management-app/releases) de ce dépôt.
2. Télécharge l'archive `Form_Sae24_Stargate_v1.0.0.zip`.
3. Extrais l'intégralité de l'archive dans un dossier (ne lance pas l'exécutable depuis le ZIP).
4. Lance `Form_Sae24_Stargate.exe`.
5. **Identifiants de connexion par défaut :**
   - **Identifiant :** `Andreas`
   - **Mot de passe :** `Andreas`

#### Option 2 : Compilation depuis les sources

1. **Cloner le dépôt :**

   ```bash
   git clone https://github.com/AndreasColino/stargate-management-app.git
   ```

2. **Ouvrir le projet :**
   Ouvre le fichier de solution (`.sln`) dans Visual Studio.

3. **Restaurer les packages NuGet :**
   Clic droit sur la solution > Restaurer les packages NuGet.

4. **Compiler et exécuter :**
   Définis la configuration sur Release (ou Debug), puis compile et lance le projet (`F5`).

### 🇬🇧 English

#### Option 1: Standalone Download (Recommended - Windows)

*Prerequisite: Windows 10 or 11 with .NET Framework 4.7.2 (enabled by default).*

1. Go to the [**Releases**](https://github.com/AndreasColino/stargate-management-app/releases) section of this repository.
2. Download `Form_Sae24_Stargate_v1.0.0.zip`.
3. Extract the entire ZIP archive to a folder (do not run the executable from inside the ZIP).
4. Launch `Form_Sae24_Stargate.exe`.
5. **Default login credentials:**
   - **Username:** `Andreas`
   - **Password:** `Andreas`

#### Option 2: Build from Source

1. **Clone the repository:**

   ```bash
   git clone https://github.com/AndreasColino/stargate-management-app.git
   ```

2. **Open the project:**
   Open the solution file (`.sln`) in Visual Studio.

3. **Restore NuGet packages:**
   Right-click the solution > Restore NuGet Packages.

4. **Build and run:**
   Set the build configuration to Release (or Debug), then build and run (`F5`).
