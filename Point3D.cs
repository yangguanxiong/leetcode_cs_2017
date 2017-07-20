using System;
using System.Collections.Generic;
using System.Text;

public class Point3D : Point2D
{
    private double z;

    public Point3D(int px, int py, int pz) : base(px, py)
    {
        z = pz;
    }

    public Point3D() : base()
    {
        z = 0;
    }

    public double Dis3D(Point3D p)
    {
        var dist2D = base.Dis2D(p);
        return Math.Sqrt(
            dist2D * dist2D
             + (p.z - this.z) * (p.z - this.z)
             );
    }

    public override void PrintDistance(double d)
    {
        System.Console.WriteLine("3D distance: " + Math.Ceiling(d));

    }




}