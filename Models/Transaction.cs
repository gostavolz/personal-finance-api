namespace PersonalFinanceApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        
        // Tipo: "Income" para Receita ou "Expense" para Despesa
        public string Type { get; set; } = string.Empty; 
        
        // Categoria: "Alimentação", "Salário", "Lazer", etc.
        public string Category { get; set; } = string.Empty;
    }
}
