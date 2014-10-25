package _2_1lvShop;

public class Customer {
    private String name;
    private int age;
    private double balance;
    private AgeRestriction restriction;

    public Customer(String name, int age, double balance) {
        this.setName(name);
        this.setAge(age);
        this.setBalance(balance);
        this.setRestriction();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if (name.isEmpty()|| name == null){
            throw new IllegalArgumentException("Every customer must have a name!");
        }
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        if (age<=0){
            throw new IllegalArgumentException("Every customer must be born!");
        }
        this.age = age;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        if (balance<0){
            throw new IllegalArgumentException("The balance of a customer cannot be less than zero!");
        }
        this.balance = balance;
    }

    public AgeRestriction getRestriction() {
        return restriction;
    }

    public void setRestriction() {
        if (this.getAge()<18){
            this.restriction = AgeRestriction.Teenager;
        } else{
            this.restriction = AgeRestriction.None;
        }
    }

    @Override
    public String toString() {
        return String.format("{Name: %s   Age: %d   Balance: %.2f   Restriction status: %s}",
                this.getName(), this.getAge(), this.getBalance(), getRestriction().toString());
    }
}
