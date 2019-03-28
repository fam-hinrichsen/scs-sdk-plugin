namespace SCSSdkClient.Object.job
{
    /// <summary>
    ///     Cargo Values
    /// </summary>
    public class Cargo
    {
        /// <summary>
        ///     Mass in kilograms
        /// </summary>
        public float Mass { get; internal set; }

        /// <summary>
        ///     Name for internal use by code.
        ///     Limited to C-identifier characters and dots.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        ///     Name for display purposes.
        ///     Localized using the current in-game language.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        ///     Name of cargo accessory for internal use by code.
        ///     Limited to C-identifier characters and dots.
        /// </summary>
        public string AccessoryId { get; internal set; }
    }
}
