using System;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        double principal, annualRate, monthlyRate, monthlyPayment, totalPaid, totalInterest;
        int years, totalPayments;

        Console.Write("Enter loan amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (%): ");
        annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan term (years): ");
        years = Convert.ToInt32(Console.ReadLine());

        monthlyRate = (annualRate / 100) / 12;
        totalPayments = years * 12;

        monthlyPayment = principal * (monthlyRate * Math.Pow(1 + monthlyRate, totalPayments))
                        / (Math.Pow(1 + monthlyRate, totalPayments) - 1);

        totalPaid = monthlyPayment * totalPayments;
        totalInterest = totalPaid - principal;

        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}
