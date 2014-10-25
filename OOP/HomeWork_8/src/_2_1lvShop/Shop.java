package _2_1lvShop;

import _2_1lvShop.CustomException.PurchaseManagerException;
import _2_1lvShop.Products.Electronics.Appliance;
import _2_1lvShop.Products.Electronics.Computer;
import _2_1lvShop.Products.FoodProduct;
import _2_1lvShop.Products.Product;

import java.awt.*;
import java.util.*;
import java.util.List;
import java.util.stream.Collectors;

public class Shop {
    public static void main(String[] args) {

        Customer pesho = new Customer("Pesho", 17, 388.00);
        FoodProduct baklava = new FoodProduct("Baklava",3.55, 3, AgeRestriction.None, "19-10-2014");

        System.out.println(pesho);
        System.out.println(baklava);

        try {
            PurchaseManager.processPurchase(baklava,pesho);

        } catch (PurchaseManagerException e){
            System.err.println(e.getMessage());
        }

        System.out.println(pesho);
        System.out.println(baklava);

        Computer pc = new Computer("PC", 899.00, 10, AgeRestriction.None);
        Appliance app = new Appliance("App", 250.00, 10, AgeRestriction.None);
        FoodProduct sirene = new FoodProduct("Sirene", 8.95, 25,AgeRestriction.Adult, "25-12-2014");
        FoodProduct bob = new FoodProduct("Bob", 5.40, 100,AgeRestriction.Adult, "31-12-2014");

        Comparator<Product> byExpire = (p1, p2) -> Long.compare(
                ((FoodProduct) p1).getExpirationDate().getTime(), ((FoodProduct) p2).getExpirationDate().getTime());
//        Comparator<Product> byPrice = (p1, p2) -> p1.getPrice().(p2.getPrice());

        LinkedList<Product> list = new LinkedList<>();
        list.add(pc);
        list.add(app);
        list.add(sirene);
        list.add(bob);
        Product soonExpirable = list.stream().filter(a->a instanceof FoodProduct).sorted(byExpire).findFirst().get();

        System.out.println(soonExpirable);

        List<Product> onlyForAdult = list.stream().filter(a->a.getAgeRestriction() == AgeRestriction.Adult).sorted((a,b)->Double.compare(a.getPrice(),b.getPrice())).collect(Collectors.toList());

        for (Product prod: onlyForAdult){
            System.out.println(prod);
        }


    }
}
