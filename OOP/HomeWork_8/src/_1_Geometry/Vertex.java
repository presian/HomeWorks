package _1_Geometry;

public abstract class Vertex {
    private double x;
    private double y;

    public Vertex(double x, double y) {
        this.setX(x);
        this.setY(y);
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }

    @Override
    public String toString() {
        return String.format("X = %.2f  Y = %.2f", this.getX(), this.getY());
    }
}
