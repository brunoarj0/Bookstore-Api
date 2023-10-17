using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models;

public class LoanModel
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Digite o nome do Recebedor!")]
    public string Receiver { get; set; }

    [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
    public string Supplier { get; set; }

    [Required(ErrorMessage = "Digite o nome do Livro!")]
    public string BookName { get; set; }

    public DateTime LastModified { get; set; } = DateTime.Now;
}