namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     States of the Wheels
    /// </summary>
    public class Wheels
    {
        /// About: Velocity
        /// Positive velocity corresponds to forward movement
        /// 
        /// About: Steering
        /// Value is from <0.25,0.25> range in counterclockwise
        /// direction when looking from top (e.g. 0.25 corresponds to left and -0.25 corresponds to right)
        /// 
        /// Set to zero for non-steered wheels
        /// 
        /// About: Rotation
        /// Value is from
        /// <0.0,1.0) range in which value increase corresponds to forward movement
        ///     About: Lift
        ///     For use with simple lifted/ non-lifted test or logical visualization of the lifting progress.
        ///  
        ///     - Value of 0 corresponds to non-lifted axle.
        ///     - Value of 1 corresponds to fully lifted axle.
        ///     Set to zero or not provided for non-liftable axles.
        ///     About: LiftOffset
        ///     Might have non-linear relation to lift ratio.
        ///     Set to zero or not provided for non-liftable axles.

        /// <summary>
        ///     Substance below the wheel
        /// </summary>
        public uint[] Substance { get; internal set; }

        /// <summary>
        ///     Vertical displacement of the wheel from its axis in meters
        /// </summary>
        public float[] SuspDeflection { get; internal set; }

        /// <summary>
        ///     Angular velocity of the wheel in rotations per second
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Positive velocity corresponds to forward movement
        /// <!----> **INFORMATION** <!---->
        public float[] Velocity { get; internal set; }

        /// <summary>
        ///     Steering rotation of the wheel in rotations
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Value is from &lt;0.25,0.25&gt; range in counterclockwise direction when looking from top (e.g. 0.25 corresponds to left and -0.25 corresponds to right)
        /// 
        /// Set to zero for non-steered wheels
        /// <!----> **INFORMATION** <!---->
        public float[] Steering { get; internal set; }

        /// <summary>
        ///     Rolling rotation of the wheel in rotations
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Value is from &lt;0.0,1.0) range in which value increase corresponds to forward movement
        /// <!----> **INFORMATION** <!---->
        public float[] Rotation { get; internal set; }

        /// <summary>
        ///     Lift state of the wheel &lt;0;1&gt;
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// For use with simple lifted/non-lifted test or logical visualization of the lifting progress.
        ///  
        /// Value of 0 corresponds to non-lifted axle.
        /// Value of 1 corresponds to fully lifted axle.
        /// 
        /// Set to zero or not provided for non-liftable axles.
        /// <!----> **INFORMATION** <!---->
        public float[] Lift { get; internal set; }

        /// <summary>
        ///     Vertical displacement of the wheel axle from its normal position in meters as result of lifting.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Might have non-linear relation to lift ratio.
        /// 
        /// Set to zero or not provided for non-liftable axles.
        /// <!----> **INFORMATION** <!---->
        public float[] LiftOffset { get; internal set; }

        /// <summary>
        ///     Is the wheel in contact with ground?
        /// </summary>
        public bool[] OnGround { get; internal set; }

    }
}
