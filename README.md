# pr74_scrum_app

# 2. Règles de développement

## 2.1. Type des issues

Il existe 5 types d'issues :

* **User story** : Demande de fonctionnalité formulée tel que : « En tant que x, je souhaite y, afin de z »
* **Documentation** : Demande de documentation
* **Conception** : Demande de conception
* **Bug** : Demande de résolution de bug
* **Technical story** : Tâche technique autre

> NB : Ticket = Issue

## 2.2. Principaux scripts

* `npm install` : installer les dépendances de la solution
* `npm start` : démarrer la solution en mode de développement

## 2.3. Procédure d'implémentation d'une issue

1. Se rendre sur la liste des issues du projet :

   * https://github.com/MaloLM/pr74-scrum-app/issues
  
2. Prendre une issue non déjà marquée comme « ouvert »

3. Créer une nouvelle branche de développement depuis la branche `master` selon la nomenclature suivante : `issue/<numéro de l'issue>-<quelques mots décrivant l'issue>`

   > Pour se placer dans la branche `master` : `git checkout master`
   >
   > Pour créer une nouvelle branche : `git checkout -b issue/123-lorem-ipsum`

4. Traiter l'issue

   > Ne pas hésiter à traiter l'issue en binôme si cela semble nécessaire.

5. Ajouter les fichiers au versionnement, les commiter et pousser la branche finalisée vers le dépôt de code

   > Pour ajouter les fichiers au versionnement : `git add <nom du fichier>`
   >
   > Pour commiter les fichiers : `git commit -m "<en anglais : verbe d'action à l'infinitif + description>"`
   >
   > Pour pousser la branche : `git push origin issue/123-lorem-ipsum `

6. Créer une demande de fusion de la branche de développement depuis l'onglet « Pull Requests » du dépôt de code GitHub 

   > À la création d'une demande de branche, la qualité du code est analysé.
   >
   > Lien vers l'onglet « Pull Requests » : https://github.com/utbm-ta70-presentation-alexa/open-days-with-alexa/pulls

7. Faire relire son code par un autre membre de l'équipe

8.  Procéder à la fusion de la branche de développement vers la branche `master` en cliquant sur le bouton « Merge pull request » de la « Pull request » précédemment créée

9. Clôturer l'issue

    > Pour cloturer une issue, il faut cliquer sur son titre pour l'ouvrir, puis cliquer sur le bouton « Close issue »

## 2.3. Conventions de nommage

### 2.3.1 lANGAGE DE PROGRAMMATION A DEFINIR

| Élément            | Casse      |
| ------------------ | ---------- |
| Classe d'objet     |            |
| Classe d'interface |            |
| Fichier            |            |
| Variable           |            |
