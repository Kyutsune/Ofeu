using UnityEngine;
public class Hit_Object
{
    public int moment_apparition { get; set; }
    public bool cree { get; set; }

    protected Type_appui type_appui;

    private GameObject gameObjectInstance;

    public Hit_Object(int moment_apparition)
    {
        this.moment_apparition = moment_apparition;
        this.type_appui = Type_appui.En_attente;
        cree = false;
    }

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
