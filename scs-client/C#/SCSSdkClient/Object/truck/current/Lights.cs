using SCSSdkClient.Enums;

namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Lightlevel and state of Light
    /// </summary>
    public class Lights
    {
        /// About: Blinker Avtive
        /// This represents the logical enable state of the blinker. It
        /// it is true as long the blinker is enabled regardless of the
        /// physical enabled state of the light (i.e. it does not blink
        /// and ignores enable state of electric).

        /// <summary>
        ///     Are the auxiliary front lights active?
        /// </summary>
        public AuxLevel AuxFront { get; internal set; }

        /// <summary>
        ///     Are the auxiliary roof lights active?
        /// </summary>
        public AuxLevel AuxRoof { get; internal set; }

        /// <summary>
        ///     Intensity of the dashboard backlight as factor &lt;0;1&gt;
        /// </summary>
        public float DashboardBacklight { get; internal set; }

        /// <summary>
        ///     Is the left blinker enabled?
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// This represents the logical enable state of the blinker. It
        /// it is true as long the blinker is enabled regardless of the
        /// physical enabled state of the light (i.e. it does not blink
        /// and ignores enable state of electric).
        /// <!----> **INFORMATION** <!---->
        public bool BlinkerLeftActive { get; internal set; }

        /// <summary>
        ///     Is the light in the left blinker currently on?
        /// </summary>
        public bool BlinkerLeftOn { get; internal set; }

        /// <summary>
        ///     Is the Right blinker enabled?
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// This represents the logical enable state of the blinker. It
        /// it is true as long the blinker is enabled regardless of the
        /// physical enabled state of the light (i.e. it does not blink
        /// and ignores enable state of electric).
        /// <!----> **INFORMATION** <!---->
        public bool BlinkerRightActive { get; internal set; }

        /// <summary>
        ///     Is the light in the Right blinker currently on?
        /// </summary>
        public bool BlinkerRightOn { get; internal set; }

        /// <summary>
        ///     Are the parking lights enabled?
        /// </summary>
        public bool Parking { get; internal set; }

        /// <summary>
        ///     Are the BeamLow lights enabled?
        /// </summary>
        public bool BeamLow { get; internal set; }

        /// <summary>
        ///     Are the BeamHigh lights enabled?
        /// </summary>
        public bool BeamHigh { get; internal set; }

        /// <summary>
        ///     Are the Beacon lights enabled?
        /// </summary>
        public bool Beacon { get; internal set; }

        /// <summary>
        ///     Are the Brake lights enabled?
        /// </summary>
        public bool Brake { get; internal set; }

        /// <summary>
        ///     Are the Reverse lights enabled?
        /// </summary>
        public bool Reverse { get; internal set; }
    }
}
