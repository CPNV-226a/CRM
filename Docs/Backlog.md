# 226 - CRM - Backlog

* Auteur : Nicolas Glassey
* Projet : CRM
* Module : 226a

---

## Contexte
Votre client vous confie le développement d'un outil simple de gestion de contacts non-commerciale. Il s'agit d'un ONG voulant mieux organiser ces campagnes d'informations et de préventions.

### Rôle

Les rôles ainsi que la notion d'authentifcation sont développés par une autre équipe de développement. Seuls les aspects métiers nous intéresserons dans cette phase de projet.

### Fonctionnalités à développer

**1ère étape de développement, le contact**

---
* Créer et afficher un contact :
    * Les propriétés sont :
        * Nom : "Ricard"
        * Prénom : "Mathieu"
        * Date de naissance : "15-FEB-1946"
        * Nationalité : France
        * Email : "mathieu.ricard@monk.org"
        * Image : Photo de profile (un lien vers le fichier)
        * Une date de création calculée par le système : [JJ/MMM/YYYY]
        * Une date de dernière mise à jour calculée par le système : [JJ/MMM/YYYY]
            * Une mise à jour est soit provquée par :
                * modification d'un champ (n'importe lequel)
                * Cas particulier : la suppression d'une image.
    * Toutes les propriétés sont obligatoires, à l'exception de l'image.

---

* Modifier un contact existant :
    * Hormis l'adresse email (qui est l'identifiant naturel), tous les champs doivent pouvoir être mis à jour.

**2eme étape de développement, les listes de contacts**
---
* Créer des listes de contacts : 
    * Afin de pouvoir faire des publipostages et autres campagnes d'information, on veut pouvoir gérer des listes d'emails.
    * On doit être capable de créer de nouvelles listes
        * Une liste est définie par un nom (unique) : "Manifestation 15 avril 2021"
        * Un nombre d'abonnés (contacts)
        * Une date de création calculée par le système : [JJ/MMM/YYYY]
        * Une date de dernière mise à jour calculée par le système : [JJ/MMM/YYYY]
            * Une mise à jour est soit provoquée par : 
                * l'ajout ou, 
                * la suppression d'un contact.
            * La mise à jour d'une donnée d'un contact n'est pas comprise.
        * Une liste d'adresse email ([RFC](http://www.faqs.org/rfcs/rfc822.html))
        * Il est possible de créer une liste sans adresse email

---
* Mettre à jour des listes :
    * On doit pouvoir ajouter à une liste existante : 
        * soit une adresse unique 
        * soit une liste d'adresses.
    * On doit pouvoir supprimer des éléments d'une liste existante :
        * soit une adresse
        * soit une liste d'adresses.
    * Il n'est pas possible d'ajouter deux fois la même adresse dans une liste donnée.

---
* Extraire les listes sur un fichier de type .csv.