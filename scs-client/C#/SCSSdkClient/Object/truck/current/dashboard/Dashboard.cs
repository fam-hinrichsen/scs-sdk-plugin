using SCSSdkClient.Object.truck.current.dashboard;

namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Speed, RPM, Pressures, Temperatures
    /// </summary>
    public class Dashboard
    {
        /// <summary>
        ///     Initialise a dashboard object
        /// </summary>
        public Dashboard()
        {
            FuelValue = new Fuel();
            WarningValues = new Warnings();
            Speed = new Movement();
            CruiseControlSpeed = new Movement();
        }

        /// About: Speed
        /// Uses negative value to represent reverse movement
        /// 
        /// About: CruiseControlSpeed
        /// Is zero if the cruise control is disabled
        /// 
        /// About: GearDashboard
        ///  
        /// - > 0  - Forward gears
        /// -    0  - Neutral
        /// - < 0  - Reverse gears

        ///<summary>
        ///     Information about fuel: amount, range, average consumption
        /// </summary>
        public Fuel FuelValue { get; internal set; }
        /// <summary>
        ///     Display active warnings
        /// </summary>
        public Warnings WarningValues { get; internal set; }


        /// <summary>
        ///     Selected gear displayed on dashboard
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// &gt; 0 - Forward gears
        /// 0 - Neutral
        /// &lt; 0 - Reverse gears
        /// <!----> **INFORMATION** <!---->
        public int GearDashboards { get; internal set; }

        /// <summary>
        ///     Speedometer speed in m/s
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Uses negative value to represent reverse movement
        /// <!----> **INFORMATION** <!---->
        public Movement Speed { get; internal set; }

        /// <summary>
        ///     Speed selected for the cruise control in m/s
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Is zero if cruise control is disabled.
        /// <!----> **INFORMATION** <!---->
        public Movement CruiseControlSpeed { get; internal set; }

        /// <summary>
        ///     Amount of AdBlue in liters
        /// </summary>
        public float AdBlue { get; internal set; }

        /// <summary>
        ///     Pressure of the oil in psi
        /// </summary>
        public float OilPressure { get; internal set; }

        /// <summary>
        ///     Temperature of the oil in degrees celsius
        /// </summary>
        public float OilTemperature { get; internal set; }

        /// <summary>
        ///     Temperature of the water in degrees celsius
        /// </summary>
        public float WaterTemperature { get; internal set; }

        /// <summary>
        ///     Voltage of the battery in volts
        /// </summary>
        public float BatteryVoltage { get; internal set; }

        /// <summary>
        ///     RPM of the engine
        /// </summary>
        public float RPM { get; internal set; }

        /// <summary>
        ///     The value of the odometer in km
        /// </summary>
        public float Odometer { get; internal set; }

        /// <summary>
        ///     are the wipers enabled?
        /// </summary>
        public bool Wipers { get; internal set; }

        /// <summary>
        ///     Is the CruiseControl active?
        /// </summary>
        public bool CruiseControl { get; internal set; }  
    }
}
