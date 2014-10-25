package _1_Geometry.PlaneShapes2D;

import _1_Geometry.Vertex;

public class Triangle extends PlaneShape {
    private Vertex2D pointA;
    private Vertex2D pointB;
    private Vertex2D pointC;


    public Triangle(double x, double y, double x1, double y1, double x2, double y2) {
        super(x, y);
        this.setPointA(new Vertex2D(x, y));
        this.setPointB(new Vertex2D(x1, y1));
        this.setPointC(new Vertex2D(x2, y2));
        this.vertex2Ds[1] = pointB;
        this.vertex2Ds[2] = pointC;
    }

    public Vertex2D getPointA() {
        return pointA;
    }

    public void setPointA(Vertex2D pointA) {
        this.pointA = pointA;
    }

    public Vertex2D getPointB() {
        return pointB;
    }

    public void setPointB(Vertex2D pointB) {
        this.pointB = pointB;
    }

    public Vertex2D getPointC() {
        return pointC;
    }

    public void setPointC(Vertex2D pointC) {
        this.pointC = pointC;
    }



    @Override
    public double getArea() {
        double lengthAB = getLengthBetweenTwoVertex(this.getPointA(), this.getPointB());
        double lengthBC = getLengthBetweenTwoVertex(this.getPointB(), this.getPointC());
        double lengthAC = getLengthBetweenTwoVertex(this.getPointA(), this.getPointC());

        double halfPerimeter = this.getPerimeter() / 2;
        double area = Math.sqrt(halfPerimeter * (halfPerimeter - lengthAB) * (halfPerimeter - lengthBC) * (halfPerimeter - lengthAC));
        return area;
    }

    @Override
    public double getPerimeter() {
        double lengthAB = getLengthBetweenTwoVertex(this.getPointA(), this.getPointB());
        double lengthBC = getLengthBetweenTwoVertex(this.getPointB(), this.getPointC());
        double lengthAC = getLengthBetweenTwoVertex(this.getPointA(), this.getPointC());

        return lengthAB + lengthBC + lengthAC;

    }

        public double getLengthBetweenTwoVertex(Vertex2D pointA, Vertex2D pointB) {
        double first = (pointA.getX() - pointB.getX())*(pointA.getX() - pointB.getX());
        double second = (pointA.getY() - pointB.getY())*(pointA.getY() - pointB.getY());
        double length = Math.sqrt(first+second);
        return length;
    }

//    @Override
//    public String toString() {
//        return super.toString();
//    }



}


