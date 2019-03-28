﻿namespace SCSSdkClient.Object {
    /// <summary>
    ///     Contains a in-game speed value (m/s), Kph (Km/h) and Mph of a speed value
    /// </summary>
    public class Movement {
        /// <summary>
        ///     In-game speed value in m/s
        /// </summary>
        public float Value { get; internal set; }

        /// <summary>
        ///     In-game speed value in Kph (Km/h)
        /// </summary>
        public float Kph => Value * 3.6f;

        /// <summary>
        ///     In-game speed value in Mph
        /// </summary>
        public float Mph => Value * 2.25f;
    }
}