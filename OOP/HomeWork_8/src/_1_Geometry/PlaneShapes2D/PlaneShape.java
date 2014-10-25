package _1_Geometry.PlaneShapes2D;

import _1_Geometry.Interfaces.AreaMeasurable;
import _1_Geometry.Interfaces.PerimeterMeasurable;
import _1_Geometry.Shape;
import _1_Geometry.Vertex;

public abstract class PlaneShape extends Shape implements AreaMeasurable,PerimeterMeasurable {

    public Vertex2D[] vertex2Ds = new Vertex2D[3];

    protected PlaneShape(double x, double y) {
        this.vertex2Ds[0] = new Vertex2D(x,y);
        this.vertices.add(vertex2Ds);
    }

    @Override
     public abstract double getArea();

    @Override
    public abstract double getPerimeter();

    @Override
    public String toString() {
        String type = this.getClass().toString().substring(this.getClass().toString().lastIndexOf(".")+1,this.getClass().toString().length());
        String allVertex = "[ ";
        for (Vertex vert:vertex2Ds){
            if (vert!=null){
                allVertex+=vert.toString()+"; ";
            }
        }
        allVertex += "]";
        return String.format("%s\nArea = %.2f\nPerimeter = %.2f\n",type, getArea(),getPerimeter(),this.vertex2Ds[0].toString())+allVertex;
    }
}
