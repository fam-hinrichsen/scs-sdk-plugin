namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Wear of Truck parts
    /// </summary>
    public class Damage
    {
        /// <summary>
        ///     Wear of the engine accessory as &lt;0;1&gt;
        /// </summary>
        public float Engine { get; internal set; }

        /// <summary>
        ///     Wear of the transmission accessory as &lt;0;1&gt;
        /// </summary>
        public float Transmission { get; internal set; }

        /// <summary>
        ///     Wear of the cabin accessory as &lt;0;1&gt;
        /// </summary>
        public float Cabin { get; internal set; }

        /// <summary>
        ///     Wear of the chassis accessory as &lt;0;1&gt;
        /// </summary>
        public float Chassis { get; internal set; }

        /// <summary>
        ///     Average wear across the wheel accessory as &lt;0;1&gt;
        /// </summary>
        public float WheelsAvg { get; internal set; }
    }
}
