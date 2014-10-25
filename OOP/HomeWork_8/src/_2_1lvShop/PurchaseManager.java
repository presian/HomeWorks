package _2_1lvShop;

import _2_1lvShop.CustomException.*;
import _2_1lvShop.Products.FoodProduct;
import _2_1lvShop.Products.Product;

public final class PurchaseManager {
    public static void processPurchase(Product product, Customer customer) throws PurchaseManagerException{
        if (product.getQuantity() < 1) {
            throw new OutOfStockException();
        }
        if (customer.getBalance() < product.getPrice()) {
            throw new NotEnoughMoneyException();
        }
        if (product.getAgeRestriction().compareTo(customer.getRestriction())>0){
            throw new AgeRestrictionException();
        }
        if (((FoodProduct) product).getExpirationDate().before(((FoodProduct) product).getDateNow())) {
            throw new ExpiredProductException();
        }
        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance() - product.getPrice());
    }
}
