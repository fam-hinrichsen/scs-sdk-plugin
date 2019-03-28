namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Represents the acceleration values for the truck
    /// </summary>
    public class TruckAcceleration : Acceleration
    {
        /// <summary>
        ///     Represents cabin space angular velocity of the cabin measured in rotation/s
        /// </summary>
        public FVector CabinAngularVelocity { get; internal set; }

        /// <summary>
        ///     Represents cabin space angular acceleration of the cabin measured in rotations/s^2
        /// </summary>
        public FVector CabinAngularAcceleration { get; internal set; }
    }
}
