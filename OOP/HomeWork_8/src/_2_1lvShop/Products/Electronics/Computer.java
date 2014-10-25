package _2_1lvShop.Products.Electronics;

import _2_1lvShop.AgeRestriction;

public class Computer extends ElectronicsProducts {

    public Computer(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction, 24);

    }

    @Override
    public double getPrice() {
        if (this.getQuantity()>1000){
            return super.getPrice()*0.95;
        }
        return super.getPrice();
    }
}
