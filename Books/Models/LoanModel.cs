namespace Bookstore.Models;

public class LoanModel
{
    public Guid Id { get; set; }
    public string Receiver { get; set; }
    public string Supplier { get; set; }
    public string BookName { get; set; }
    public DateTime LastModified { get; set; }
}