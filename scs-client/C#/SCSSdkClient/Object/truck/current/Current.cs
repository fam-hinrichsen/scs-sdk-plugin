namespace SCSSdkClient.Object.truck.current {
    /// <summary>
    ///     Represents the current status of the truck
    /// </summary>
    public class Current {
        /// <summary>
        ///     Initialise a current truck object
        /// </summary>
        public Current()
        {
            MotorValues = new Motor();
            DashboardValues = new Dashboard();
            LightsValues = new Lights();
            WheelsValues = new Wheels();
            DamageValues = new Damage();
            PositionValue = new DPlacement();
            AccelerationValues = new TruckAcceleration();
        }

        /// <summary>
        ///     Is the electric enabled
        /// </summary>
        public bool ElectricEnabled { get; internal set; }

        /// <summary>
        ///     Is the engine enabled?
        /// </summary>
        public bool EngineEnabled { get; internal set; }
        /// <summary>
        ///     Current values of the motor
        ///     <seealso cref="Motor"/> for more information
        /// </summary>
        public Motor MotorValues { get; internal set; }
        /// <summary>
        ///     Values that are displayed at the dashboard like rpm, fuelValue, ...
        ///     <seealso cref="Dashboard"/> for more information
        /// </summary>
        public Dashboard DashboardValues { get; internal set; }
        /// <summary>
        ///     Information about the Lights of the truck
        ///     <seealso cref="Lights"/> for more information
        /// </summary>
        public Lights LightsValues { get; internal set; }
        /// <summary>
        ///     Current values of the wheels like rotation, substance, ...
        ///     <seealso cref="Wheels"/>
        /// </summary>
        public Wheels WheelsValues { get; internal set; }
        /// <summary>
        ///     Wear of the Truck
        /// </summary>
        public Damage DamageValues { get; internal set; }
        /// <summary>
        ///     Acceleration of the Truck
        ///     <seealso cref="TruckAcceleration"/> for more information
        /// </summary>
        public  TruckAcceleration AccelerationValues { get; internal set; }

        /// <summary>
        ///     Represents world space position and orientation of the truck.
        /// </summary>
        public DPlacement PositionValue { get; protected internal set; }
    }
}