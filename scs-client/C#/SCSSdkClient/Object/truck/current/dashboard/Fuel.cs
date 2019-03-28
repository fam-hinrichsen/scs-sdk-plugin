namespace SCSSdkClient.Object.truck.current.dashboard
{
    /// <summary>
    ///     Contains Fuel values
    /// </summary>
    public class Fuel
    {
        /// <summary>
        ///     Amount of fuel in liters
        /// </summary>
        public float Amount { get; internal set; }

        /// <summary>
        ///     Average consumption of the fuel in liters/km
        /// </summary>
        public float AverageConsumption { get; internal set; }

        /// <summary>
        ///     Estimated range of truck with current amount of fuel in km
        /// </summary>
        public float Range { get; internal set; }
    }
}
