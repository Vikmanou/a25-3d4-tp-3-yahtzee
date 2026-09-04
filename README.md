# Yahtzee — TP-3

Jeu de Yahtzee deux joueurs développé en C# WinForms (.NET 8).

## Fonctionnalités

- Gestion des joueurs : création, modification, suppression avec couleur personnalisée et couleur de dé
- Export des données d'un joueur en JSON
- Impression des données via PDF
- Partie en deux joueurs avec 5 dés, 3 lancers par tour, 13 tours chacun
- Animation de mélange des dés entre les lancers
- Maintien des dés en main (clic pour garder/relâcher)
- Calcul automatique des scores Yahtzee (uns, deux, …, Yahtzee, full, suites, etc.)
- Bonus si total des dés 1–6 ≥ 63
- Affichage du gagnant en fin de partie
- Tests unitaires MSTest sur `CalculateurScore`

## Structure

```
TP-3/
├── TP-3/                  # Projet WinForms principal
│   ├── Form1.cs           # Menu principal — sélection des joueurs
│   ├── Form2.cs           # Gestion des joueurs (CRUD)
│   ├── Form3.cs           # Interface de jeu
│   ├── Joueur.cs          # Modèle joueur
│   ├── Partie.cs          # Logique de partie (dés, tours, lancers)
│   └── CalculateurScore.cs# Calculs de score Yahtzee
├── TP-3_testsUnitaires/   # Tests MSTest
├── fichiers/              # Fichiers de référence
└── prototypes/            # Maquettes initiales
```

## Prérequis

- .NET 8 SDK
- Windows (WinForms)
- Visual Studio 2022+ recommandé

## Lancer le projet

```bash
cd TP-3/TP-3
dotnet run
```

Ou ouvrir `TP-3.sln` dans Visual Studio et appuyer sur F5.

## Tests

```bash
cd TP-3/TP-3_testsUnitaires
dotnet test
```
