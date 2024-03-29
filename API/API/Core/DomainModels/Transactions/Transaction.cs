﻿using API.Core.DomainModels.Base;
using API.Core.DomainModels.Transactions;
using System;

namespace API.Core.DomainModels
{
    public class Transaction : EntityBase
    {
        public string CurrencyCode { get; set; }
        public Decimal Amount { get; set; }
        public Status Status { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public static TransactionDTO Cast(Transaction t)
        {
            return  new TransactionDTO()
            {
                Id = t.Id,
                CurrencyCode = t.CurrencyCode,
                Amount = t.Amount,
                Status = t.Status,
                TransactionDate = t.TransactionDate
            };
        }
    }
}
