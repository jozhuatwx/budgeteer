﻿namespace BudgeteerShared.Models;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public required string Name { get; set; }
    public required Money Amount { get; set; }
    public Money? OriginalAmount { get; set; }
    public string? Notes { get; set; }

    public required int AccountId { get; set; }
    public virtual Account? Account { get; set; }
    public required int CategoryId { get; set; }
    public virtual Category? Category { get; set; }

    [SetsRequiredMembers]
    public Transaction(string name, Money amount, int accountId, int categoryId)
    {
        Timestamp = DateTime.Now;
        Name = name;
        Amount = amount;
        AccountId = accountId;
        CategoryId = categoryId;
    }
}

