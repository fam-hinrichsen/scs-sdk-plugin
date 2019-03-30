using System.Collections.Generic;
using SCSSdkClient.Object.truck;
using SCSSdkClient.Object.trailer;
using SCSSdkClient.Object.control;
using SCSSdkClient.Object.job;
using System;

namespace SCSSdkClient.Object {
    /// <summary>
    ///     Telemetry Data of SCS SDK's 
    /// </summary>
    public class SCSTelemetry {
        private const float PiTimes2 = 6.2831853071795864769252867665590058f;

        /// <summary>
        /// initialise an SCSTelemetry object
        /// </summary>
        public SCSTelemetry()
        {
            GameVersion = new Version();
            TelemetryVersion = new Version();
            TruckValues = new Truck();
            JobValues = new Job();
            CommonValues = new Common();
            TrailerValues = new Trailer();
            ControlValues = new Control();
            NavigationValues = new Navigation();
            SpecialEventsValues = new SpecialEvents();
            Substances = new List<Substance>();
        }

        /// <summary>
        ///     Timestamp not the in game time,
        /// </summary>
        /// <seealso cref="Common.GameTime" />
        public uint Timestamp { get; internal set; }

        /// <summary>
        ///     Is the game actual paused? (Menu, F1, Map, etc. open)
        /// </summary>
        /// <example>
        ///     Driving
        ///     <code>
        ///         Paused == true
        ///     </code>
        ///     Menu/Map
        ///     <code>
        ///         Paused == false
        ///     </code>
        /// </example>
        public bool Paused { get; internal set; }

        /// <summary>
        ///     Which game data we collect?
        /// </summary>
        /// <example>
        ///     Running game is EuroTruckSimulator2
        ///     <code>
        ///         Game == SCSGame.Ets2
        ///     </code>
        ///     Running game is AmericanTruckSimulator
        ///     <code>
        ///         Game == SCSGame.Ats
        ///     </code>
        /// </example>
        /// <seealso cref="SCSGame" />
        public SCSGame Game { get; internal set; }

        /// <summary>
        ///     Version of the game for purpose of the specific api which is being initialized.
        ///     Does *NOT* match the patch level of the game
        /// </summary>
        public Version GameVersion { get; internal set; }
        
        /// <summary>
        ///     Version/Revision of the dll
        /// </summary>
        /// <value>
        ///     actually it is the revision number
        /// </value>
        public uint DllVersion { get; internal set; }

        /// <summary>
        ///     Version of the Game Telemetry
        /// </summary>
        public Version TelemetryVersion { get; internal set; }

        /// <summary>
        ///     Contains "common" values -> scale, gameTime and reststop
        /// </summary>
        public Common CommonValues { get; internal set; }

        /// <summary>
        ///     Contains values of the truck
        /// </summary>
        public Truck TruckValues { get; internal set; }

        /// <summary>
        ///     Contains values of the Trailer
        /// </summary>
        public Trailer TrailerValues { get; internal set; }

        /// <summary>
        ///     Contains values of the actual job
        /// </summary>
        public Job JobValues { get; internal set; }

        /// <summary>
        ///     Contains values about the user and game control
        /// </summary>
        public Control ControlValues { get; internal set; }

        /// <summary>
        ///     Navigation values
        /// </summary>
        public Navigation NavigationValues { get; internal set; }

        /// <summary>
        ///     Contains special Event Values like onJob and JobFinished
        /// </summary>
        public SpecialEvents SpecialEventsValues { get; internal set; }

        /// <summary>
        ///     Contains string values to the substances used in values like Truck.Current.Wheels.Substance
        /// </summary>
        public List<Substance> Substances { get; internal set; }

        /// <summary>
        ///     Converts uint minutes in a DateTime object
        /// </summary>
        /// <param name="minutes">In-Game Minutes</param>
        /// <returns>
        ///     DateTime object of the in-game time
        /// </returns>
        internal static DateTime MinutesToDate(uint minutes) => new DateTime((long)minutes * 10000000 * 60, DateTimeKind.Utc);

        /// <summary>
        ///     Converts int minutes in a DateTime object
        /// </summary>
        /// <param name="minutes">In-Game Minutes</param>
        /// <returns>
        ///     DateTime object of the in-game time
        /// </returns>
        internal static DateTime MinutesToDate(int minutes) => new DateTime((long)Math.Abs(minutes) * 10000000 * 60, DateTimeKind.Utc);

        /// <summary>
        ///     Adds two float vectors
        /// </summary>
        /// <param name="first">
        ///     First Float Vector
        /// </param>
        /// <param name="second">
        ///     Second Float Vector
        /// </param>
        /// <returns>
        ///     Sum of both Float Vectors
        /// </returns>
        public static FVector Add(FVector first, FVector second) => new FVector { X = first.X + second.X, Y = first.Y + second.Y, Z = first.Z + second.Z };

        /// <summary>
        ///     Adds float vector to double vector
        /// </summary>
        /// <param name="first">
        ///     double vector
        /// </param>
        /// <param name="second">
        ///     float vector
        /// </param>
        /// <returns>
        ///     sum as double vector
        /// </returns>
        public static DVector Add(DVector first, FVector second) => new DVector { X = first.X + second.X, Y = first.Y + second.Y, Z = first.Z + second.Z };

        /// <summary>
        ///     Rotates specified vector by specified orientation
        /// </summary>
        /// <param name="orientation">
        ///     given orientation
        /// </param>
        /// <param name="vector">
        ///     given float vector
        /// </param>
        /// <returns>
        ///     rotated float vector
        /// </returns>
        public static FVector Rotate(Euler orientation, FVector vector)
        {
            var headingRadians = orientation.Heading * PiTimes2;
            var pitchRadians = orientation.Pitch * PiTimes2;
            var rollRadians = orientation.Roll * PiTimes2;

            var cosHeading = Math.Cos(headingRadians);
            var sinHeading = Math.Sin(headingRadians);
            var cosPitch = Math.Cos(pitchRadians);
            var sinPitch = Math.Sin(pitchRadians);
            var cosRoll = Math.Cos(rollRadians);
            var sinRoll = Math.Sin(rollRadians);

            // Roll around Z axis
            var postRollX = (vector.X * cosRoll) - (vector.Y * sinRoll);
            var postRollY = (vector.X * sinRoll) + (vector.Y * cosRoll);
            var postRollZ = vector.Z;

            // Pitch around X axis
            var postPitchX = postRollX;
            var postPitchY = (postRollY * cosPitch) - (postRollZ * sinPitch);
            var postPitchZ = (postRollY * sinPitch) + (postRollZ * cosPitch);

            // heading around y axis
            return new FVector
            {
                X = (float)((postPitchX * cosHeading) + (postPitchZ * sinHeading)),
                Y = (float)postPitchY,
                Z = (float)((-postPitchX * sinHeading) + (postPitchZ * cosHeading))
            };
        }

        internal void SetGameTime(uint gameTime)
        {
            CommonValues.GameTime.Value = gameTime;
            if (gameTime > 0 && gameTime < 4000000000 && JobValues.DeliveryTime.Value > 0)
            {
                JobValues.RemainingDeliveryTime.Value = (int)(JobValues.DeliveryTime.Value - gameTime);
            }
            else
            {
                JobValues.RemainingDeliveryTime.Value = 0;
            }
        }

        internal void SetTruckPosition(DPlacement position)
        {
            TruckValues.CurrentValues.PositionValue = position;
            TruckValues.Positioning.TruckPosition = position;
        }
    }
}