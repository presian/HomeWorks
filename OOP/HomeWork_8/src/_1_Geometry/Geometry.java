package _1_Geometry;

import _1_Geometry.Interfaces.PerimeterMeasurable;
import _1_Geometry.Interfaces.VolumeMeasurable;
import _1_Geometry.PlaneShapes2D.*;
import _1_Geometry.PlaneShapes2D.Rectangle;
import _1_Geometry.SpaceShapes3D.Cuboid;
import _1_Geometry.SpaceShapes3D.SpaceShape;
import _1_Geometry.SpaceShapes3D.Sphere;
import _1_Geometry.SpaceShapes3D.SquarePyramid;

import java.awt.*;
import java.util.*;
import java.util.List;
import java.util.stream.Collectors;

public class Geometry {
    public static void main(String[] args) {

        Shape[] shapes = new Shape[]{
            new Rectangle(2.0,3.0,2,3),
            new Triangle(2.5, 3.1, 8.5, 6.66,7.45, 8.94),
            new Circle(2.5,3.6,2.8),
            new Cuboid(2.5,3.5,5.6,4.5,3.6,4.8),
            new Sphere(3.8,4.3,6.8,9.5),
            new SquarePyramid(3.9,9.66,4.88,7.55,3.94),
        };

//        for (Shape shape : shapes){
//            System.out.println(shape);
//        }
        List<Shape> over40Volume = Arrays.asList(shapes).stream().filter(a->a instanceof  VolumeMeasurable)
                .filter(b->((VolumeMeasurable)b).getVolume()>40).collect(Collectors.toList());
        over40Volume.forEach(a->System.out.println(a));


        Comparator<Shape> byPerimeter = (s1, s2) -> {
            PerimeterMeasurable Shape1 = (PerimeterMeasurable) s1;
            PerimeterMeasurable Shape2 = (PerimeterMeasurable) s2;
            double perimeterShape1 = Shape1.getPerimeter();
            double perimeterShape2 = Shape2.getPerimeter();

            return perimeterShape1 < perimeterShape2 ? -1 :
                    perimeterShape1 > perimeterShape2 ? 1 : 0;
        };
        System.out.println("\n\n\n");

        List<Shape> planeShapesByPerimeter = Arrays.asList(shapes)
                .stream()
                .filter(p -> p instanceof PerimeterMeasurable)
                .sorted(byPerimeter)
                .collect(Collectors.toList());

        for (Shape shape : planeShapesByPerimeter) {
            System.out.println(shape);
        }

    }
}
