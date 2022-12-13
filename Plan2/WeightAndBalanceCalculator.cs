namespace Planner.WeightAndBalance
{
    using System;

    namespace WeightAndBalanceCalculator
    {
        class WeightAndBalanceCalculator
        {
            // Declare variables for the weight and balance calculations
            double airplaneEmptyWeight;
            double pilotWeight;
            double passengerWeight;
            double fuelWeight;
            double cargoWeight;
            double emptyWeightMoment;
            double pilotArm;
            double passengerArm;
            double cargoArm;
            double fuelArm;

            public WeightAndBalanceCalculator(string AircraftCodeName, double PilotWeight, double PassengerWeight, double cargoWeight, double fuelWeight)
            {
                switch (AircraftCodeName)
                {
                    case "PAPA":
                        this.airplaneEmptyWeight = 404;
                        this.pilotWeight = PilotWeight;
                        this.passengerWeight = PassengerWeight;
                        this.fuelWeight = fuelWeight;
                        this.cargoWeight = cargoWeight;
                        this.emptyWeightMoment = 685.99;

                        pilotArm = 1.8;
                        passengerArm = 1.8;
                        cargoArm = 2.26;
                        fuelArm = 1.53;

                        break;
                    default:
                        break;
                }

            }

            // Method to perform the weight and balance calculations for takeoff
            public WeightConfiguration CalculateWeightAndBalanceForTakeoff()
            {
                // Calculate the total weight of the airplane by adding the weights of the pilot, passenger, fuel, and cargo
                double totalWeight = airplaneEmptyWeight + pilotWeight + passengerWeight + fuelWeight + cargoWeight;
                double totalMoment = emptyWeightMoment + (pilotWeight * pilotArm) + (passengerWeight * passengerArm) + (fuelWeight * fuelArm) + (cargoWeight * cargoArm);

                return new WeightConfiguration() { PilotWeightMoment = (pilotWeight * pilotArm), FuelMoment = (fuelWeight * fuelArm), CargoMoment = (cargoWeight * cargoArm), CopilotWeightMoment = (passengerWeight * passengerArm), TotalWeight = totalWeight, TotalMoment = totalMoment, TotalArm = Math.Round(totalMoment / totalWeight, 2) };

            }

            // Method to perform the weight and balance calculations for landing
            public WeightConfiguration CalculateWeightAndBalanceForLanding(double fuelBurned)
            {
                // Calculate the total weight of the airplane by adding the weights of the pilot, passenger, fuel, and cargo
                double totalWeight = airplaneEmptyWeight + pilotWeight + passengerWeight + fuelWeight + cargoWeight - fuelBurned;
                double totalMoment = emptyWeightMoment + (pilotWeight * pilotArm) + (passengerWeight * passengerArm) + ((fuelWeight - fuelBurned) * fuelArm) + (cargoWeight * cargoArm);
                return new WeightConfiguration() { TotalWeight = totalWeight, TotalMoment = totalMoment, TotalArm = Math.Round(totalMoment / totalWeight), CargoMoment = (cargoWeight * cargoArm), CopilotWeightMoment = (passengerWeight * passengerArm), FuelMoment = (fuelBurned * fuelArm), PilotWeightMoment = (pilotWeight * pilotArm) };
            }
        }
        internal class WeightConfiguration
        {
            public double TotalWeight { get; set; }
            public double TotalMoment { get; set; }
            public double TotalArm { get; set; }
            public double PilotWeightMoment { get; set; }
            public double CopilotWeightMoment { get; set; }
            public double CargoMoment { get; set; }
            public double FuelMoment { get; set; }
        }
    }
}
