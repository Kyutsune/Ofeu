using UnityEngine;

public class Gestion_prefab
{
    private GameObject cercleTestPrefab;

    public Gestion_prefab(GameObject prefab)
    {
        cercleTestPrefab = prefab;
    }

    public void CreerPrefab_cercle(Circles circle)
    {
        if (cercleTestPrefab != null)
        {
            Vector3 prefabPosition = new Vector3(circle.position.x, circle.position.y, 0);
            GameObject circleObject = Object.Instantiate(cercleTestPrefab, prefabPosition, Quaternion.identity);
            circle.SetGameObject(circleObject); // Associe le GameObject instancié
        }
        else
        {
            Debug.LogError("cercleTestPrefab is not assigned in Gestion_prefab.");
        }
    }
}
