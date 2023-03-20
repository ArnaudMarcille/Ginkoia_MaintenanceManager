# Ginkoya_MaintenanceManager

Dans l’atelier dans un magasin, 3 techniciens ont besoin de tracer leurs travaux réalisés. 

L’hiver le magasin gère des skis, l’été le magasin gère des vélos.

Les travaux pour les skis sont : 
    Affutage et fartage, facturé 20€ et réalisé généralement en 15 minutes.
    Réparation, selon le temps passé et les pièces à changer : fixation complète, semelle 

Les travaux pour les vélos sont : 
    Révision annuelle, facturée 50€ et réalisée en 45 minutes.
    Réparation, selon le temps passé 1€ par minute et les pièces à changer : roue, pneu, câble de frein

Le client est identifié par un nom, prénom, mail et téléphone. 

Le vélo et skis sont identifié par un numéro série.

Une application va leur être réalisée pour les accompagner dans leur quotidien. 

## Concept

### ASP Net core blazor

## Model 

```mermaid

---
title: Ginkoya
---

classDiagram
direction RL
class Customer {
    int Id
    string Name
    string LastName
    string Mail
    string Phone
}


class Equipment {
    int Id
    string Label
    string SerialNumber
    int FK_TypeId
    int FK_CustomerId
}

class equipmentType {
    int Id
    string Label
}

class WorkType {
    int Id
    string Label
    bool HaveFixedPrice
    int Price
    int duration
    int FK_TargerEquipmentType
}

class Work {
    int Id
    DateTime Date
    string technician
    int Duration
    int finalPrice

    int FK_equipmentId
    int FK_WorkTypeId
}

class Catalog {
    int Id
    string Label
    int Price
}

class WorksChangedPart {
    int FK_WorkId
    int Id
    string Label
    int price
    int originalProductId
}

Customer "1" <-- "n" Equipment
Equipment "n" <-- "1" equipmentType
Equipment "1" <-- "n" Work 
WorkType "n" <-- "1" Work
equipmentType "n" <-- "1" WorkType
Work "1" <-- "n" WorksChangedPart
WorksChangedPart "1" --> "n" Catalog

```


