using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSSdkClient.Object.truck.current
{
    /// <summary>
    ///     Slected Gear, HShifter... etc.
    /// </summary>
    public class Gear
    {
        /// About: HShifterSlot
        /// 0 means that no slot is selected
        ///  
        /// About: Gear
        ///  
        /// - > 0  - Forward gears
        /// -    0  - Neutral
        /// - < 0  - Reverse gears

        /// <summary>
        ///     Gearbox slot the h-shifter handle is currently in.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// 0 means that no slot is selected
        /// <!----> **INFORMATION** <!---->
        public uint HShifterSlot { get; internal set; }

        /// <summary>
        ///     Selected gear in the engine
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// &gt; 0 - Forward gears
        /// 0 - Neutral
        /// &lt; 0 - Reverse gears
        /// <!----> **INFORMATION** <!---->
        public int Selected { get; internal set; }

        /// <summary>
        ///     Enabled state of range/splitter selector toggles
        /// </summary>
        public bool[] HShifterSelector { get; internal set; }
    }
}
