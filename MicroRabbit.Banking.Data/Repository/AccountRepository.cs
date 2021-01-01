using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Context;
using System;
using System.Collections.Generic;


namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}