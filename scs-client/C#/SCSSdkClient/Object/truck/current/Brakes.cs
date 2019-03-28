namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Brake Values
    /// </summary>
    public class Brakes
    {
        /// About: RetarderLevel
        /// <0;max>
        ///     where 0 is disabled retarder and max is maximal value found in Truck configuration
        /// 
        /// See Also:
        ///     <Constants.Motor.RetarderStepCount>

        /// <summary>
        /// Current level of the retarder
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        ///  0;max where 0 is disabled retarder and max is maximal value found in TRUCK configuration
        ///  <!----> **INFORMATION** <!---->
        ///   <seealso cref="Constants.Motor.RetarderStepCount" />.
        public uint RetarderLevel { get; internal set; }

        /// <summary>
        ///     Pressure in the brake air tank in psi
        /// </summary>
        public float AirPressure { get; internal set; }

        /// <summary>
        ///     Temperature of the brakes in degrees celsius.
        /// </summary>
        public float Temperature { get; internal set; }

        /// <summary>
        ///     Is the parking brake enabled?
        /// </summary>
        public bool ParkingBrake { get; internal set; }

        /// <summary>
        ///     Is the motor brake enabled?
        /// </summary>
        public bool MotorBrake { get; internal set; }
    }
}
