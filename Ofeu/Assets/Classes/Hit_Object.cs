public enum Type_appui
{
    Parfait,
    Bon,
    Raté,
    En_attente
}

public class Hit_Object
{
    public int moment_apparition { get; set; }
    public bool cree { get; set; }

    protected Type_appui type_appui;

    public Hit_Object(int moment_apparition)
    {
        this.moment_apparition = moment_apparition;
        this.type_appui = Type_appui.En_attente;
        cree = false;
    }


}
