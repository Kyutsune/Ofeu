public class Circles : Hit_Object
{
    public Coordonnée position { get; set; }
    
    public Circles(int x, int y, int mom_app) : base(mom_app)
    {
        position = new Coordonnée(x, y);
    }
}
