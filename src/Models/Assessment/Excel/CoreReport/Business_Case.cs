﻿namespace Azure.Migrate.Export.Models
{
    public class Business_Case
    {
        public BusinessCaseDatasetCostDetails OnPremisesIaaSCost { get; set; }
        public BusinessCaseDatasetCostDetails OnPremisesPaaSCost { get; set; }
        public BusinessCaseDatasetCostDetails TotalOnPremisesCost { get; set; }
        public BusinessCaseDatasetCostDetails AzureIaaSCost { get; set; }
        public BusinessCaseDatasetCostDetails AzurePaaSCost { get; set; }
        public BusinessCaseDatasetCostDetails TotalAzureCost { get; set; }

        public Business_Case()
        {
            OnPremisesIaaSCost = new BusinessCaseDatasetCostDetails();
            OnPremisesPaaSCost = new BusinessCaseDatasetCostDetails();
            TotalOnPremisesCost = new BusinessCaseDatasetCostDetails();
            AzureIaaSCost = new BusinessCaseDatasetCostDetails();
            AzurePaaSCost = new BusinessCaseDatasetCostDetails();
            TotalAzureCost = new BusinessCaseDatasetCostDetails();
        }
    }
}
