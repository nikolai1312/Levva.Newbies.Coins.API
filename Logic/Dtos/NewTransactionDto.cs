﻿using Levva.Newbies.Coins.API.Domain.Enum;

namespace Levva.Newbies.Coins.API.Logic.Dtos
{
    public class NewTransactionDto
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public TransactionTypeEnum Tipo { get; set; }
        public Guid CategoryId { get; set; }
    }
}
