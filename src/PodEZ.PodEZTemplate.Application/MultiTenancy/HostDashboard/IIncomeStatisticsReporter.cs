using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PodEZ.PodEZTemplate.MultiTenancy.HostDashboard.Dto;

namespace PodEZ.PodEZTemplate.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}