package _2_1lvShop.CustomException;

public class ExpiredProductException extends PurchaseManagerException {

    public ExpiredProductException() {
        super("The product is expired");
    }
}
