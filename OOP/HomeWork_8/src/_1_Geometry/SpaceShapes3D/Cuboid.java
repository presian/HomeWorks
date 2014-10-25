package _1_Geometry.SpaceShapes3D;

public class Cuboid extends SpaceShape {
    private Vertex3D pivotVertex;
    private double width;
    private double height;
    private double depth;

    public Cuboid(double x, double y, double z, double width, double height, double depth) {
        super(x, y, z);
        this.setPivotVertex(new Vertex3D(x,y,z));
        this.setWidth(width);
        this.setHeight(height);
        this.setDepth(depth);
    }

    public Vertex3D getPivotVertex() {
        return pivotVertex;
    }

    public void setPivotVertex(Vertex3D pivotVertex) {
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

    public double getDepth() {
        return depth;
    }

    public void setDepth(double depth) {
        this.depth = depth;
    }

    @Override
    public double getArea() {
        double baseArea = this.width * this.depth;
        double sideArea = this.depth * this.height;
        double frontArea = this.width * this.height;
        double area = (baseArea + sideArea + frontArea)*2;
        return area;
    }

    @Override
    public double getVolume() {
        double volume = this.width * this.depth * this.height;
        return volume;
    }
}
