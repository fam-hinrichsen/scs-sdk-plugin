namespace SCSSdkClient.Object.trailer {
    /// <summary>
    ///     Trailer Values
    /// </summary>
    public class Trailer {
        /// <summary>
        ///     Initialise a trailer object
        /// </summary>
        public Trailer() {
            Wheelvalues = new Wheels();
            AccelerationValues = new Acceleration();
            WheelsConstant = new WheelsConstants();
            Hook = new FVector();
        }

        /// <summary>
        ///     Is the trailer connected to the truck
        /// </summary>
        public bool Attached { get; internal set; }

        /// <summary>
        ///     Wear of the chassis accessory as &lt;0;1&gt;
        /// </summary>
        public float Damage { get; internal set; }

        /// <summary>
        ///     Default position of the hook in vehicle space
        /// </summary>
        public FVector Hook { get; internal set; }

        /// <summary>
        ///     Current wheel values of the trailer, like rotation , substance, ...
        ///     <seealso cref="Wheels" /> for more information
        /// </summary>
        public Wheels Wheelvalues { get; internal set; }

        /// <summary>
        ///     Constant wheel values like Count, Radius,  ...
        ///     <seealso cref="WheelsConstants" /> for more information
        /// </summary>
        public WheelsConstants WheelsConstant { get; internal set; }

        /// <summary>
        ///     Acceleration values of the trailer
        ///     <seealso cref="Acceleration" /> for more informaiton
        /// </summary>
        public Acceleration AccelerationValues { get; internal set; }

        /// <summary>
        ///     Position of the trailer
        /// </summary>
        public DPlacement Position { get; internal set; }

        /// <summary>
        ///     Id for internal use by code.
        ///     Limited to C-identifier characters and dots
        /// </summary>
        public string Id { get; internal set; }
    }
}