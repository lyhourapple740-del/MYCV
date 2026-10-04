using System;

namespace VendingMachineLab
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal snackPrice = 2.00m;
            decimal moneyInserted = 5.00m;
            int stockCount = 3;
            bool isStudent = true;

            decimal finalPrice = isStudent ? (snackPrice * 0.85m) : snackPrice;

            bool isApproved = (moneyInserted >= finalPrice) && (stockCount > 0);

            decimal changeReturned = isApproved ? (moneyInserted - finalPrice) : moneyInserted;
            int remainingStock = isApproved ? (stockCount - 1) : stockCount;

            Console.WriteLine($"Original Price:   ${snackPrice:F2}");
            Console.WriteLine($"Student Discount: {isStudent}");
            Console.WriteLine($"Final Price:      ${finalPrice:F2}");
            Console.WriteLine($"Money Inserted:   ${moneyInserted:F2}");
            Console.WriteLine($"Stock Available:  {stockCount}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Purchase Approved: {isApproved}");
            Console.WriteLine($"Change Returned:  ${changeReturned:F2}");
            Console.WriteLine($"Remaining Stock:  {remainingStock}");
        }
    }
}