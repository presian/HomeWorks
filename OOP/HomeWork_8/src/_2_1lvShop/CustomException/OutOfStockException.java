package _2_1lvShop.CustomException;

public class OutOfStockException extends PurchaseManagerException {

    public OutOfStockException() {
        super("The product is out of stock!");
    }
}
