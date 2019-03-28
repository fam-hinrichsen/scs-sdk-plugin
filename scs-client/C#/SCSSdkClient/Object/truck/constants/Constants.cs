namespace SCSSdkClient.Object.truck.constants {
    /// <summary>
    ///     Config values
    /// </summary>
    public class Constants {
        /// <summary>
        ///     Initialise a constants object
        /// </summary>
        public Constants() {
            MotorValues = new Motor();
            CapacityValues = new Capacity();
            WarningFactorValues = new WarningFactor();
            WheelsValues = new WheelsConstants();
        }
        /// <summary>
        ///     Constant Motor values of the truck like gearCount, rations, ...
        ///     <seealso cref="Motor"/> for more information
        /// </summary>
        public Motor MotorValues { get; internal set; }
        /// <summary>
        ///     Capacity of fuel and adblue of the truck 
        /// </summary>
        public Capacity CapacityValues { get; internal set; }
        /// <summary>
        ///     Warning Factors of the truck
        ///     <seealso cref="WarningFactor"/> for more information
        /// </summary>
        public WarningFactor WarningFactorValues { get; internal set; }
        /// <summary>
        ///     Constant wheel values of the truck like radius, liftable, ...
        ///     <seealso cref="WheelsConstants"/> for more information
        /// </summary>
        public WheelsConstants WheelsValues { get; internal set; }

        /// <summary>
        ///     Brand id for configuration purposes.
        ///     Limited to C-identifier characters
        /// </summary>
        public string BrandId { get; internal set; }

        /// <summary>
        ///     Brand for display purposes.
        /// </summary>
        public string Brand { get; internal set; }

        /// <summary>
        ///     Name for internal use by code.
        ///     Limited to C-identifier characters and dots.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        ///     Name for display purposes
        ///     Localized using the current in-game language
        /// </summary>
        public string Name { get; internal set; }        
    }
}