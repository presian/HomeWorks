package _2_1lvShop.Products;

import _2_1lvShop.AgeRestriction;
import _2_1lvShop.Interfaces.Expirable;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class FoodProduct extends Product implements Expirable {
    public final long FIFTEEN_DAYS_IN_MILISECONDS = 1296000000;

    private Date expirationDate;
    private Date dateNow;

    public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction,
                       String expirationDate) {
        super(name, price, quantity, ageRestriction);
        this.setExpirationDate(expirationDate);
        this.setDateNow();
        if (isLessThan15DaysToExpirationDate()){
            this.setProductPrice(price*0.7);
        }
    }

    public Date getExpirationDate() {
        return this.expirationDate;
    }

    public void setExpirationDate(String expirationDate) {
        this.expirationDate = dateManipulation(expirationDate);
    }

    public Date getDateNow() {
        return dateNow;
    }

    public void setDateNow() {
        this.dateNow = new Date();
    }

    public boolean isLessThan15DaysToExpirationDate() {

        if (this.getDateNow().before(this.getExpirationDate())
                || this.getDateNow().equals(this.getExpirationDate())) {
            long diff = this.getExpirationDate().getTime() - this.getDateNow().getTime();
            if (diff < FIFTEEN_DAYS_IN_MILISECONDS){
                return true;
            }
        }

        return false;
    }

    public Date dateManipulation(String input) {
        SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
        try {
            Date date = format.parse(input);
            return date;
        } catch (ParseException e) {

        }
        return null;
    }

    @Override
    public String toString() {
        return super.toString() + String.format("   Expiration day: %s}", getExpirationDate());
    }
}
