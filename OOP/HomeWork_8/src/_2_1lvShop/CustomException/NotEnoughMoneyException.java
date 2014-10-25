package _2_1lvShop.CustomException;

public class NotEnoughMoneyException extends PurchaseManagerException{

    public NotEnoughMoneyException() {
        super("The customer have not enough money!");
    }
}
