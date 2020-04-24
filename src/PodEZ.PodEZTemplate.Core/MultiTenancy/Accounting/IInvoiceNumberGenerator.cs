﻿using System.Threading.Tasks;
using Abp.Dependency;

namespace PodEZ.PodEZTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}