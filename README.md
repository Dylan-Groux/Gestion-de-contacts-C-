
# 📇 Gestion de contacts (C#)

Une application de bureau élégante en **C# (Windows Forms)** pour gérer efficacement vos contacts personnels : ajout, modification, suppression et export au format CSV.

---

## 🚀 Présentation

Cette application vous permet de **centraliser vos contacts** et de les manipuler simplement grâce à une interface intuitive. Elle offre une gestion complète :  

- Ajout et édition détaillée des contacts  
- Visualisation claire des informations (téléphone, email, adresse)  
- Export facile de la liste complète au format CSV

---

## ✨ Fonctionnalités clés

- **Gestion complète des contacts** : création, consultation, mise à jour, suppression  
- Interface claire et réactive grâce à Windows Forms  
- **Export CSV** rapide pour sauvegarder ou partager vos données  
- Gestion d’erreurs robustes pour une utilisation fluide  
- Base de données légère SQLite intégrée pour stocker vos données localement  

---

## 🛠 Technologies utilisées

| Technologie    | Rôle                      |
|----------------|---------------------------|
| C#             | Langage principal         |
| Windows Forms  | Interface utilisateur     |
| SQLite         | Stockage local des données|
| ADO.NET        | Connexion à la base       |
| Visual Studio  | Environnement de développement |

---

## ⚙️ Installation & démarrage

1. Clonez le dépôt :  
   ```bash
   git clone https://github.com/Dylan-Groux/Gestion-de-contacts-C-.git
   ```
2. Ouvrez la solution dans **Visual Studio**  
3. Assurez-vous que la connexion SQLite est configurée  
4. Compilez et lancez le programme (`F5`)

---

## 🎯 Utilisation

- **Ajouter un contact** : cliquez sur “Nouveau contact” et remplissez le formulaire  
- **Consulter/modifier un contact** : double-cliquez sur un contact dans la liste  
- **Supprimer un contact** : sélectionnez et cliquez sur “Supprimer”  
- **Exporter** la liste complète en CSV via le bouton dédié  

---

## 📂 Export CSV

L’export génère un fichier CSV que vous pouvez sauvegarder où vous voulez.  

- Si le fichier est ouvert ailleurs, un message vous prévient pour éviter les conflits.  
- Pratique pour importer vos contacts dans d’autres applications.

---

## 🧩 Organisation du projet

- `FormMain.cs` : affichage principal & gestion des contacts  
- `FormContactDetails.cs` : édition et consultation des données individuelles  
- `Contact.cs` : définition du modèle Contact  
- `Database.cs` : gestion de la base SQLite et des requêtes  
- `CsvExporter.cs` : fonctionnalité d’export CSV  

---

## 🤝 Contribution

Contributions, idées et améliorations sont les bienvenues !  

Pour contribuer :  
1. Forkez ce dépôt  
2. Créez une branche (`git checkout -b ma-feature`)  
3. Commitez vos changements (`git commit -m "Ajout d'une nouvelle feature"`)  
4. Pushez (`git push origin ma-feature`)  
5. Ouvrez une Pull Request

---

## 👤 Auteur

**Dylan Groux** — Développeur passionné par les applications desktop simples et efficaces.

---

## 📄 Licence

Ce projet est distribué sous licence **MIT** — voir le fichier `LICENSE` pour plus d’informations.
