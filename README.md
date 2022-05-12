# pr74_scrum_app

2. Règles de développement

2.1. Type des issues

Il existe 5 types d'issues :

User story : Demande de fonctionnalité formulée tel que : « En tant que x, je souhaite y, afin de z »
Documentation : Demande de documentation
Conception : Demande de conception
Bug : Demande de résolution de bug
Technical story : Tâche technique autre
NB : Ticket = Issue

2.2. Procédure d'implémentation d'une issue

Créer un fichier .env en racine de l'espace de travail et le compléter avec les valeurs de développement local :

Se rendre sur la liste des issues du projet :

Créer une nouvelle branche de développement depuis la branche master selon la nomenclature suivante : issue/<numéro de l'issue>-<quelques mots décrivant l'issue>

Pour se placer dans la branche master : git checkout master

Pour créer une nouvelle branche : git checkout -b issue/123-lorem-ipsum
Traiter l'issue

Ne pas hésiter à traiter l'issue en binôme si cela semble nécessaire.
Ajouter les fichiers au versionnement, les commiter et pousser la branche finalisée vers le dépôt de code

Pour ajouter les fichiers au versionnement : git add <nom du fichier>

Pour commiter les fichiers : git commit -m "<en anglais : verbe d'action à l'infinitif + description>"

Pour pousser la branche : git push origin issue/123-lorem-ipsum
Créer une demande de fusion de la branche de développement depuis l'onglet « Pull Requests » du dépôt de code GitHub

À la création d'une demande de branche, la qualité du code est analysé.

Lien vers l'onglet « Pull Requests » : https://github.com/utbm-ta70-presentation-alexa/open-days-with-alexa/pulls
Faire relire son code par un autre membre de l'équipe

Procéder à la fusion de la branche de développement vers la branche master en cliquant sur le bouton « Merge pull request » de la « Pull request » précédemment créée

Clôturer l'issue

Pour cloturer une issue, il faut cliquer sur son titre pour l'ouvrir, puis cliquer sur le bouton « Close issue »
