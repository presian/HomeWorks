package _2_1lvShop.Products;

import _2_1lvShop.AgeRestriction;
import _2_1lvShop.Interfaces.Buyable;

public abstract class Product implements Buyable{
    private String name;
    private double productPrice;
    private double quantity;
    private AgeRestriction ageRestriction;

    protected Product(String name, double price, double quantity, AgeRestriction ageRestriction) {
        this.setName(name);
        this.setProductPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name == null || name.isEmpty()){
            throw new IllegalArgumentException("Name cannot be empty or null!");
        }
        this.name = name;
    }

    public double getProductPrice() {
        return productPrice;
    }

    public void setProductPrice(double productPrice) {
        if (productPrice<=0){
            throw new IllegalArgumentException("The price cannot be zero or less!");
        }
        this.productPrice = productPrice;
    }

    public double getQuantity() {
        return quantity;
    }

    public void setQuantity(double quantity) {
        if (quantity<0){
            throw new IllegalArgumentException("The quantity cannot be less than zero!");
        }
        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }

    @Override
    public double getPrice(){
        return this.getProductPrice();
    }

    @Override
    public String toString() {
        return String.format("Product {Name: %s   Price: %.2f   Quantity: %.2f   Restriction status: %s",
                this.getName(), this.getProductPrice(), this.getQuantity(), getAgeRestriction().toString());
    }
}
