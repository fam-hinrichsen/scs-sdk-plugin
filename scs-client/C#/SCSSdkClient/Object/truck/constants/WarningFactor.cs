namespace SCSSdkClient.Object.truck.constants
{
    /// <summary>
    ///     At which value X give a warning?
    /// </summary>
    public class WarningFactor
    {
        /// <summary>
        ///     Fraction of the fuel capacity bellow which is activated the fuel warning.
        /// </summary>
        public float Fuel { get; internal set; }

        /// <summary>
        ///     Fraction of the adblue capacity bellow which is activated the adblue warning.
        /// </summary>
        public float AdBlue { get; internal set; }

        /// <summary>
        ///     Pressure of the air in the tank bellow which the warning activates
        /// </summary>
        public float AirPressure { get; internal set; }

        /// <summary>
        ///     Pressure of the air in the tank bellow which the emergency brakes activate
        /// </summary>
        public float AirPressureEmergency { get; internal set; }

        /// <summary>
        ///     Pressure of the oil bellow which the warning activates.
        /// </summary>
        public float OilPressure { get; internal set; }

        /// <summary>
        ///     Temperature of the water above which the warning activates.
        /// </summary>
        public float WaterTemperature { get; internal set; }

        /// <summary>
        ///     Voltage of the battery bellow which the warning activates.
        /// </summary>
        public float BatteryVoltage { get; internal set; }
    }
}
