namespace SCSSdkClient.Object.truck.current.dashboard
{
    /// <summary>
    ///     Warnings
    /// </summary>
    public class Warnings
    {
        /// <summary>
        ///     Is the air pressure warning active?
        /// </summary>
        public bool AirPressure { get; internal set; }

        /// <summary>
        ///     Are the emergency brakes active as result of low air pressure?
        /// </summary>
        public bool AirPressureEmergency { get; internal set; }

        /// <summary>
        ///     Is the fuel warning active?
        /// </summary>
        public bool FuelW { get; internal set; }

        /// <summary>
        ///     Is the adblue warning active?
        /// </summary>
        public bool AdBlue { get; internal set; }

        /// <summary>
        ///     Is the oil pressure warning active?
        /// </summary>
        public bool OilPressure { get; internal set; }

        /// <summary>
        ///     Is the water temperature warning active?
        /// </summary>
        public bool WaterTemperature { get; internal set; }

        /// <summary>
        ///     Is the battery voltage warning active?
        /// </summary>
        public bool BatteryVoltage { get; internal set; }
    }
}
