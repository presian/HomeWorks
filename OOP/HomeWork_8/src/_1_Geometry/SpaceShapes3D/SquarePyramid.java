package _1_Geometry.SpaceShapes3D;

public class SquarePyramid extends SpaceShape {
    private Vertex3D baseCenter;
    private double baseWidth;
    private double pyramidHeight;
    private double baseArea;

    public SquarePyramid(double x, double y, double z, double baseWidth, double pyramidHeight) {
        super(x, y, z);
        this.baseCenter = new Vertex3D(x,y,z);
        this.setBaseWidth(baseWidth);
        this.setPyramidHeight(pyramidHeight);
        this.baseArea = this.baseWidth * this.baseWidth;
    }

    public Vertex3D getBaseCenter() {
        return baseCenter;
    }

    public void setBaseCenter(Vertex3D baseCenter) {
        this.baseCenter = baseCenter;
    }

    public double getBaseWidth() {
        return baseWidth;
    }

    public void setBaseWidth(double baseWidth) {
        this.baseWidth = baseWidth;
    }

    public double getPyramidHeight() {
        return pyramidHeight;
    }

    public void setPyramidHeight(double pyramidHeight) {
        this.pyramidHeight = pyramidHeight;
    }

    @Override
    public double getArea() {
        double heightOfSide = Math.sqrt((this.baseWidth / 2 * this.baseWidth / 2) + (this.pyramidHeight * this.pyramidHeight));
        double sideArea = this.baseWidth * heightOfSide / 2;
        double pyramidArea = baseArea + 4 * sideArea;
        return pyramidArea;
    }

    @Override
    public double getVolume() {
        double pyramidVolume = this.baseArea * pyramidHeight / 3;
        return pyramidVolume;
    }
}
