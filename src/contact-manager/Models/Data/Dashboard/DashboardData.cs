using System.Collections.Generic;

namespace contact_manager.Models.Data
{
    public class DashboardData
    {

        public int ActiveCustomerCount { get; init; }

        public int PassiveCustomerCount { get; init; }

        public string?[] CustomerCityNames { get; init; }

        public double[] CustomerCityCounts { get; init; }

        public string[] CustomerTypes { get; init; }

        public double[] CustomerTypeCounts { get; init; }


        public DashboardData(int activeCustomerCount, int passiveCustomerCount,
            string?[] customerCityNames, double[] customerCityCounts,
            string[] customerTypes, double[] customerTypeCounts)
        {
            this.ActiveCustomerCount = activeCustomerCount;
            this.PassiveCustomerCount = passiveCustomerCount;
            this.CustomerCityNames = customerCityNames;
            this.CustomerCityCounts = customerCityCounts;
            this.CustomerTypes = customerTypes;
            this.CustomerTypeCounts = customerTypeCounts;
        }
    }
}
