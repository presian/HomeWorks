package _1_Geometry.PlaneShapes2D;

import _1_Geometry.Interfaces.AreaMeasurable;
import _1_Geometry.Interfaces.PerimeterMeasurable;

public class Circle extends PlaneShape implements AreaMeasurable, PerimeterMeasurable {
    private double radius;
    private Vertex2D center;

    public Circle(double x, double y, double radius) {
        super(x, y);
        this.setRadius(radius);
        this.setCenter(new Vertex2D(x,y));
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    public Vertex2D getCenter() {
        return center;
    }

    public void setCenter(Vertex2D center) {
        this.center = center;
    }

    @Override
    public double getArea() {
        return Math.PI * this.radius * this.radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * this.radius;
    }
}

