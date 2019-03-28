using System;
using SCSSdkClient.Object;
namespace SCSSdkClient.Object {
    /// <summary>
    ///     Like Time object represent minutes and DateTime object, but represent more a timespan positive or negative
    /// </summary>
    public class Frequency {
        /// <summary>
        ///     Represented in number of in-game minutes
        /// </summary>
        public int Value { get; internal set; }

        /// <summary>
        ///     Represented in data of in-game minutes
        /// </summary>
        public DateTime Date => SCSTelemetry.MinutesToDate(Value);
 
    }
}