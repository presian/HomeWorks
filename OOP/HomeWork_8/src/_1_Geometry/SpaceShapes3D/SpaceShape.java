package _1_Geometry.SpaceShapes3D;

import _1_Geometry.Interfaces.AreaMeasurable;
import _1_Geometry.Interfaces.VolumeMeasurable;
import _1_Geometry.Shape;

public abstract class SpaceShape extends Shape implements VolumeMeasurable, AreaMeasurable {
    Vertex3D[] vertex3Ds = new Vertex3D[1];

    protected SpaceShape(double x, double y, double z) {
        this.vertex3Ds[0] = new Vertex3D(x, y, z);
    }

    @Override
    public abstract double getArea();

    @Override
    public abstract double getVolume();

    @Override
    public String toString() {
        String type = this.getClass().toString().substring(this.getClass().toString().lastIndexOf(".") + 1, this.getClass().toString().length());
        String vert = String.format("[ X: %f    Y: %f    Z: %f ]",this.vertex3Ds[0].getX(),this.vertex3Ds[0].getY(),this.vertex3Ds[0].getZ());
        return String.format("%s\nArea: %.2f\nVolume: %.2f\n%s", type, this.getArea(), this.getVolume(),vert);
    }
}
