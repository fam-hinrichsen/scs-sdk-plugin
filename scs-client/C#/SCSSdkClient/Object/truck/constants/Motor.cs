namespace SCSSdkClient.Object.truck.constants
{
    /// <summary>
    ///     Gear, Retarder, etc.
    /// </summary>
    public class Motor
    {
        /// About: RetarderStepCount

        /// Set to zero if retarder is not mounted on the truck
        /// <summary>
        ///     Number of forward gears on undamaged truck
        /// </summary>
        public uint ForwardGearCount { get; internal set; }

        /// <summary>
        ///     Number of reverse gears on undamaged truck
        /// </summary>
        public uint ReverseGearCount { get; internal set; }

        /// <summary>
        ///     Number of steps in the retarder
        /// </summary>
        /// <!---->
        /// **INFORMATION**
        /// <!---->
        /// Set to zero if retarder is not mounted on the truck
        /// <!---->
        /// **INFORMATION**
        /// <!---->
        public uint RetarderStepCount { get; internal set; }

        /// <summary>
        ///     Number of selectors (e.g. range/splitters toggles)
        /// </summary>
        public uint SelectorCount { get; internal set; }

        /// <summary>
        ///     Gear selected when requirements for this h-shifter slot are meet.
        /// </summary>
        public int[] SlotGear { get; internal set; }

        /// <summary>
        ///     Position of h-shifter handle.
        ///     Zero corresponds to neutral position. Mapping to physical position of
        ///     the handle depends on input setup.
        /// </summary>

        public uint[] SlotHandlePosition { get; internal set; }

        /// <summary>
        ///     Bitmask of required on/off state of selectors.
        ///     Only first selector_count bits are relevant.
        /// </summary>
        public uint[] SlotSelectors { get; internal set; }

        /// <summary>
        ///     Maximal rpm value.
        /// </summary>
        public float EngineRpmMax { get; internal set; }

        /// <summary>
        ///     Differential ratio of the truck.
        /// </summary>
        public float DifferentialRation { get; internal set; }

        /// <summary>
        ///     Forward transmission ratios
        /// </summary>
        public float[] GearRatiosForward { get; internal set; }

        /// <summary>
        ///     Reverse transmission ratios
        /// </summary>
        public float[] GearRatiosReverse { get; internal set; }

        /// <summary>
        ///     Type of the shifter.
        /// </summary>
        public ShifterType ShifterTypeValue { get; internal set; }
    }

}
