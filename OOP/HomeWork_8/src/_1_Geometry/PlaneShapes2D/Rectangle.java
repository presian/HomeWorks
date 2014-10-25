package _1_Geometry.PlaneShapes2D;

public class Rectangle extends PlaneShape {
    private Vertex2D pivotVertex;
    private double width;
    private double height;

    public Rectangle(double x, double y, double width, double height) {
        super(x, y);
        this.pivotVertex = new Vertex2D(x,y);
        this.width = width;
        this.height = height;
    }

    public Vertex2D getPivotVertex() {
        return pivotVertex;
    }

    public void setPivotVertex(Vertex2D pivotVertex) {
        this.pivotVertex = pivotVertex;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public double getArea() {
        return this.width * this.height;
    }

    @Override
    public double getPerimeter() {
        return this.width * 2 + this.height * 2;
    }

//    @Override
//    public String toString() {
//        return super.toString() + String.format("\nPivotVertex: %s",this.pivotVertex.toString());
//
//    }
}
