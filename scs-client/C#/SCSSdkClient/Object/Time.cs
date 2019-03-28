﻿using System;

namespace SCSSdkClient.Object {
    /// <summary>
    ///     Represent a time object with time in minutes and a DateTime object
    /// </summary>
    public class Time {
        /// <summary>
        ///     Represented in number of in-game minutes
        /// </summary>
        public uint Value { get; internal set; }

        /// <summary>
        ///     Represented in data of in-game minutes
        /// </summary>
        public DateTime Date => SCSTelemetry.MinutesToDate(Value);

             
    }
}