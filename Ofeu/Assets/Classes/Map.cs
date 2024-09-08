using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public List<Hit_Object> hitObjects;
    private Gestion_prefab gestionPrefab;

    public Map(Gestion_prefab gestionPrefab)
    {
        hitObjects = new List<Hit_Object>();
        this.gestionPrefab = gestionPrefab;
    }

    public void AddHitObject(Hit_Object hitObject)
    {
        hitObjects.Add(hitObject);
    }

    public void RemoveHitObject(Hit_Object hitObject)
    {
        hitObjects.Remove(hitObject);

        // Suppression physique du préfabriqué de la scène, si nécessaire
        if (hitObject is Circles circle)
        {
            GameObject circleObject = circle.GetGameObject();
            if (circleObject != null)
            {
                Object.Destroy(circleObject);
            }
        }
    }

    public void CreaMapTest()
    {
        Circles circle1 = new Circles(1, 2, 3);
        Circles circle2 = new Circles(2, 3, 5);

        AddHitObject(circle1);
        AddHitObject(circle2);
    }

    public void Update(float tempsActuel)
    {
        foreach (Hit_Object hitObject in hitObjects)
        {
            if (hitObject.moment_apparition <= tempsActuel && !hitObject.cree)
            {
                Debug.Log("Moment apparition: " + hitObject.moment_apparition);
                hitObject.cree = true;

                if (hitObject is Circles circle)
                {
                    gestionPrefab.CreerPrefab_cercle(circle);
                }
            }
        }

        // Gestion des clics
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Vérifie si le clic touche un objet Circles dans la liste
                GameObject hitObject = hit.collider.gameObject;
                Circles circleHit = null;

                foreach (Hit_Object innerHitObject in hitObjects)
                {
                    if (innerHitObject is Circles circle)
                    {
                        GameObject circleObject = circle.GetGameObject();
                        if (circleObject != null && circleObject == hitObject)
                        {
                            circleHit = circle;
                            break;
                        }
                    }
                }

                if (circleHit != null)
                {
                    // Retirer le Hit_Object de la liste et détruire le GameObject
                    RemoveHitObject(circleHit);
                }
            }
        }
    }
}
