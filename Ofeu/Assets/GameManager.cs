using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Prefab_circle; // Préfabriqué à assigner dans l'inspecteur
    private Map map;
    private Gestion_prefab gestionPrefab;
    public float start_time;

    void Start()
    {
        gestionPrefab = new Gestion_prefab(Prefab_circle);

        map = new Map(gestionPrefab);
        map.CreaMapTest(); // Initialise la carte avec des objets

        start_time = Time.time;
    }

    void Update()
    {
        float tempsActuel = Time.time - start_time;
        map.Update(tempsActuel);
        
    }
}
