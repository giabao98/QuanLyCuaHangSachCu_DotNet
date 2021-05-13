using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ngt.Center.MultiTenancy.HostDashboard.Dto;

namespace Ngt.Center.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}