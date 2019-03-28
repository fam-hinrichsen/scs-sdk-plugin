namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Gear, Retarder, etc.
    /// </summary>
    public class Motor
    {
        /// <summary>
        ///     Initialise a motor object
        /// </summary>
        public Motor()
        {
            GearValues = new Gear();
            BrakeValues = new Brakes();
        }
        /// <summary>
        ///     Information to the current gears
        /// </summary>
        public Gear GearValues { get; internal set; }
        /// <summary>
        ///     Information around the brake state
        /// </summary>
        public Brakes BrakeValues { get; internal set; }
    }
}
