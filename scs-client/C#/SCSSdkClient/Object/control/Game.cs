namespace SCSSdkClient.Object.control
{
    /// <summary>
    ///     value used by the game
    /// </summary>
    public class Game
    {
        /// About: Steer
        /// Note that it is interpreted counterclockwise.
        /// 
        /// Accounts for interpolation speeds and simulated counterforces for digital inputs
        /// 
        /// About: Throttle
        /// Accounts for the press attack curve for digital inputs or cruise-control input.
        /// 
        /// About: Brake
        /// Accounts for the press attack curve for digital inputs. Does not contain retarder, parking or motor brake.
        /// 
        /// About: Clutch
        /// Accounts for the automatic shifting or interpolation of player input.

        /// <summary>
        ///     Steering as used by the simulation &lt;-1;1&gt;
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Note that it is interpreted counterclockwise.
        /// 
        /// Accounts for interpolation speeds and simulated counterforces for digital inputs
        /// <!----> **INFORMATION** <!---->
        /// ///
        /// <seealso cref="Input.Steering" />
        public float Steering { get; internal set; }

        /// <summary>
        ///     Throttle pedal input as used by the simulation &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Accounts for the press attack curve for digital inputs or cruise-control input.
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Input.Throttle" />
        public float Throttle { get; internal set; }

        /// <summary>
        ///     Brake pedal input as used by the simulation &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Accounts for the press attack curve for digital inputs. Does not contain retarder, parking or motor brake.
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Input.Brake" />
        public float Brake { get; internal set; }

        /// <summary>
        ///     Clutch pedal input as used by the simulation &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Accounts for the automatic shifting or interpolation of player input.
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Input.Clutch" />
        public float Clutch { get; internal set; }

    }
}
