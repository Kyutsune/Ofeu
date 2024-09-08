using UnityEngine;

public class Circles : Hit_Object
{
    public Coordonnée position { get; set; }
    private GameObject gameObjectInstance;

    public Circles(int x, int y, int mom_app) : base(mom_app)
    {
        position = new Coordonnée(x, y);
    }

    // Méthode pour obtenir le GameObject associé
    public GameObject GetGameObject()
    {
        return gameObjectInstance;
    }

    // Méthode pour définir le GameObject associé
    public void SetGameObject(GameObject go)
    {
        gameObjectInstance = go;
    }
}
