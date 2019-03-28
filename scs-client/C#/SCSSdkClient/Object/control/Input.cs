namespace SCSSdkClient.Object.control
{
    /// <summary>
    ///     Input value
    /// </summary>
    public class Input
    {
        /// About: Steering
        /// Note that it is interpreted counterclockwise.
        /// 
        /// If the user presses the steer right button on digital input (e.g. keyboard) this value goes immediatelly to -1.0
        /// 
        /// About: Throttle
        /// If the user presses the forward button on digital input (e.g. keyboard) this value goes immediatelly to 1.0
        /// 
        /// About: Brake
        /// If the user presses the brake  button on digital input (e.g. keyboard) this value goes immediatelly to 1.0
        /// 
        /// About: Clutch
        /// If the user presses the clutch button on digital input (e.g. keyboard) this value goes immediatelly to 1.0

        /// <summary>
        ///     Steering received from input &lt;-1;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// Note that it is interpreted counterclockwise.
        /// 
        /// If the user presses the steer right button on digital input (e.g. keyboard) this value goes immediatelly to -1.0
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Game.Steering" />
        public float Steering { get; internal set; }

        /// <summary>
        ///     Throttle received from input &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// If the user presses the forward button on digital input (e.g. keyboard) this value goes immediatelly to 1.0
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Game.Throttle" />
        public float Throttle { get; internal set; }

        /// <summary>
        ///     Brake received from input &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// If the user presses the brake button on digital input (e.g. keyboard) this value goes immediatelly to 1.0
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Game.Brake" />
        public float Brake { get; internal set; }

        /// <summary>
        ///     Clutch received from input &lt;0;1&gt;.
        /// </summary>
        /// <!----> **INFORMATION** <!---->
        /// If the user presses the clutch button on digital input (e.g. keyboard) this value goes immediatelly to 1.0
        /// <!----> **INFORMATION** <!---->
        /// <seealso cref="Game.Clutch" />
        public float Clutch { get; internal set; }

    }
}
