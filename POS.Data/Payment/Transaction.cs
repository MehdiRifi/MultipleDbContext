namespace POS.Data.Payment;

public class Transaction
{
    public Guid Id { get; set; }
    public int TransactionNumber { get; set; }
    public double TotalAmmount { get; set; }
}
