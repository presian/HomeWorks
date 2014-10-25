package _2_1lvShop.CustomException;

public class AgeRestrictionException extends PurchaseManagerException{
    public AgeRestrictionException() {
        super("The customer is too young!");
    }
}
