using System;

namespace SmartVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const double TAX_RATE = 0.08;
            const double DISCOUNT_RATE = 0.10;
            const int DISCOUNT_THRESHOLD = 5;

            // Inputs
            Console.Write("Enter Item Price ($): ");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity Purchased: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cash Paid ($): ");
            double cashPaid = Convert.ToDouble(Console.ReadLine());

            // Math Logic
            double subtotal = itemPrice * quantity;
            double discountAmount = (quantity >= DISCOUNT_THRESHOLD) ? (subtotal * DISCOUNT_RATE) : 0.0;
            double netSubtotal = subtotal - discountAmount;
            double taxAmount = netSubtotal * TAX_RATE;
            double totalCost = netSubtotal + taxAmount;

            // Cash Validation Check
            Console.WriteLine("\n=============================");
            if (cashPaid >= totalCost)
            {
                double changeDue = cashPaid - totalCost;

                Console.WriteLine("    RUPP VENDING RECEIPT     ");
                Console.WriteLine("=============================");
                Console.WriteLine($"Subtotal:         ${subtotal,8:F2}");
                Console.WriteLine($"Bulk Discount:   -${discountAmount,8:F2}");
                Console.WriteLine($"Sales Tax (8%):  +${taxAmount,8:F2}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total Amount:     ${totalCost,8:F2}");
                Console.WriteLine($"Cash Paid:        ${cashPaid,8:F2}");
                Console.WriteLine($"Change Due:       ${changeDue,8:F2}");
                Console.WriteLine("=============================");
                Console.WriteLine("  Thank you for your purchase!");
            }
            else
            {
                double shortAmount = totalCost - cashPaid;

                Console.WriteLine("     TRANSACTION FAILED      ");
                Console.WriteLine("=============================");
                Console.WriteLine($"Total Cost:       ${totalCost,8:F2}");
                Console.WriteLine($"Cash Paid:        ${cashPaid,8:F2}");
                Console.WriteLine($"Shortage Amount: -${shortAmount,8:F2}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Error: Insufficient cash paid!");
                Console.WriteLine("=============================");
            }
        }
    }
}