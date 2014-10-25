package _1_Geometry.SpaceShapes3D;

public class Sphere extends SpaceShape {
    private Vertex3D center;
    private double radius;

    public Sphere(double x, double y, double z, double radius) {
        super(x, y, z);
        this.setCenter(new Vertex3D(x,y,z));
        this.setRadius(radius);
        this.vertex3Ds[0] = this.getCenter();
    }

    public Vertex3D getCenter() {
        return center;
    }

    public void setCenter(Vertex3D center) {
        this.center = center;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    @Override
    public double getArea() {
        return 4 * Math.PI * this.radius * this.radius;
    }

    @Override
    public double getVolume() {
        return ((4 * Math.PI * Math.pow(this.radius, 3)) / 3);
    }
}
