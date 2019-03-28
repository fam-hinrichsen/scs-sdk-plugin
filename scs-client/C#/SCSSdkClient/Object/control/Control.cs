namespace SCSSdkClient.Object.control {
    /// <summary>
    ///     User Input value and value used by the game
    /// </summary>
    public class Control {
        /// <summary>
        /// Initialise a Control object
        /// </summary>
        public Control()
        {
            InputValues = new Input();
            GameValues = new Game();
        }

        /// <summary>
        ///     Contains the values of the user input
        /// </summary>
        public Input InputValues { get; internal set; }
        /// <summary>
        ///     Cpntains the values the game use
        /// </summary>
        public Game GameValues { get; internal set; }


        /// <inheritdoc />
        public override string ToString() {
            return $"Input Values:\n\t{InputValues.ToString().StringFormater()}\nGame Values:\n\t{GameValues.ToString().StringFormater()}";
        }
    }
}