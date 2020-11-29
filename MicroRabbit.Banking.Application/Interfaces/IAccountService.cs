using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
         IEnumerable<Account> GetAccount();
         
    }
}