class Discount {
    public static void Main(string[] args) {
        float Milcloth = 0F;
        float Handcloth = 0F;
        float MBill = 0F;
        float HBill = 0F;
        int amount = System.Convert.ToInt32(args[0]);

        switch (amount) {
            case 1:
                if (amount < 100 && amount > 0) {
                    Milcloth = 0F;
                    Handcloth = 5.0F;
                }
                break;
            case 2:
                if (amount > 101 && amount < 200) {
                    Milcloth = 5.0F;
                    Handcloth = 7.5F;
                }
                break;
            case 3:
                if (amount < 300 && amount > 201) {
                    Milcloth = 7.5F;
                    Handcloth = 10.0F;
                }
                break;
            case 4:
                if (amount > 300) {
                    Milcloth = 10.0F;
                    Handcloth = 15.0F;
                }
                break;
            default:
                System.Console.WriteLine("Enter correct amount");
                break;
        }

        if (Milcloth != 0F || Handcloth != 0F) {
            MBill = amount - (amount * Milcloth / 100);
            HBill = amount - (amount * Handcloth / 100);
            System.Console.WriteLine("Milcloth Bill: " + MBill);
            System.Console.WriteLine("Handcloth Bill: " + HBill);
        }
    }
}
 