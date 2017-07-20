using System;
using System.Collections.Generic;
using System.Text;

public class Point2D{
    private int px;
    private int py;

    public Point2D(){

    }

    public Point2D(int x, int y){
        this.px = x;
        this.py = y;
    }

    public virtual double Dis2D(Point2D p){
        return Math.Sqrt((p.px - this.px) * (p.px - this.px) + (p.py - this.py) * (p.py - this.py));
    }

    public virtual void PrintDistance(double d){
        System.Console.WriteLine("2D distance: " + Math.Ceiling(d));

    }
}

