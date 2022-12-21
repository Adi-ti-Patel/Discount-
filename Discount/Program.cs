using Discount;

Customer cus = new RetailCustomer();
Console.WriteLine($"Retail Discount - {cus.DiscountPercentage}");

cus = new PublicCustomer();
Console.WriteLine($"Public Discount - {cus.DiscountPercentage}");

cus = new InternalCustomer();
Console.WriteLine($"Internal Discount - {cus.DiscountPercentage}");