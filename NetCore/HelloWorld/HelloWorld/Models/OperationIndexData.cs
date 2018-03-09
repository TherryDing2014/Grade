using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class OperationIndexData
    {
        public string farmName;
        public double windResource;            //风资源指标	10
        public double energyResource;          //发电量指标	6
        public double reliability;             //可靠性指标	10
        public double availability;            //可利用率指标	10
        public double energyConsumption;       //能耗指标		10
        public double ops;                     //运维指标		5

        public OperationIndexData()
        {

        }

        public OperationIndexData(string farmName,double windResource, double energyResource,
                double reliability, double availability, double energyConsumption, double ops)
        {
            this.farmName = farmName;
            this.windResource = windResource;
            this.energyResource = energyResource;
            this.reliability = reliability;
            this.availability = availability;
            this.energyConsumption = energyConsumption;
            this.ops = ops;
        }

        public OperationIndexData(OperationIndexData other)
        {
            this.farmName = other.farmName;
            this.windResource = other.windResource;
            this.energyResource = other.energyResource;
            this.reliability = other.reliability;
            this.availability = other.availability;
            this.energyConsumption = other.energyConsumption;
            this.ops = other.ops;
        }
    }
}
