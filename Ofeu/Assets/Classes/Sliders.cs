using System.Collections.Generic;

public class Sliders:Hit_Object
{
    List <Coordonnée> points_departs_arrives { get; set; }


    public Sliders(int x, int y, int x2, int y2, int mom_app) : base(mom_app)
    {
        points_departs_arrives = new List<Coordonnée>();
        points_departs_arrives.Add(new Coordonnée(x, y));
        points_departs_arrives.Add(new Coordonnée(x2, y2));
    }   

}
