package _2_1lvShop.Products.Electronics;

import _2_1lvShop.AgeRestriction;

public class Appliance extends ElectronicsProducts {

    public Appliance(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction, 6);
    }

    @Override
    public double getPrice() {
        if (this.getQuantity() < 50) {
            return super.getPrice() * 1.05;
        }
        return super.getPrice();
    }
}
