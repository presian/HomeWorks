package _2_1lvShop.Products.Electronics;

import _2_1lvShop.AgeRestriction;
import _2_1lvShop.Products.Product;

public abstract class ElectronicsProducts extends Product {
    private int guaranteePeriod;

    protected ElectronicsProducts(String name, double price, double quantity, AgeRestriction ageRestriction, int guaranteePeriod) {
        super(name, price, quantity, ageRestriction);
        this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
        if (guaranteePeriod<1){
            throw new IllegalArgumentException("The guarantee period cannot be less than one month!");
        }
        this.guaranteePeriod = guaranteePeriod;
    }

    @Override
    public String toString() {
        return super.toString() + String.format("Guarantee period: %d}", this.getGuaranteePeriod());
    }
}
