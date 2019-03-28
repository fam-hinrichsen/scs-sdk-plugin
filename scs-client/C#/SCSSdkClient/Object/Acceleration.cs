namespace SCSSdkClient.Object
{
    /// <summary>
    ///     Represents the Acceleration values for the vehicle
    /// </summary>
    public class Acceleration
    {
        /// <summary>
        ///     Represents vehicle space linear velocity of the trailer measured in m/s
        /// </summary>
        public FVector LinearVelocity { get; internal set; }

        /// <summary>
        ///     Represents vehicle space angular velocity of the trailer measured in rotation/s
        /// </summary>
        public FVector AngularVelocity { get; internal set; }

        /// <summary>
        ///     Represents vehicle space linear acceleration of the trailer measured in m/s^2
        /// </summary>
        public FVector LinearAcceleration { get; internal set; }

        /// <summary>
        ///     Represents vehicle space angular acceleration of the trailer measured in rotations/s^2
        /// </summary>
        public FVector AngularAcceleration { get; internal set; }
    }
}
