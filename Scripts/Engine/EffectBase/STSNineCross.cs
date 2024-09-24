namespace SceneTransitionSystem
{
    /// <summary>
    /// Enum representing the nine possible crossing directions in a 3x3 grid system.
    /// </summary>
    public enum STSNineCross : int
    {
        /// <summary>
        /// Represents the top position in a 3x3 grid system.
        /// </summary>
        Top,

        /// <summary>
        /// Represents the bottom position in a 3x3 grid layout for scene transitions.
        /// </summary>
        Bottom,

        /// <summary>
        /// Represents the right position in a nine-directional cross pattern.
        /// </summary>
        Right,

        /// <summary>
        /// Represents the left position in a 3x3 grid within the Scene Transition System.
        /// It is used to specify the leftmost region in various transition effects.
        /// </summary>
        Left,

        /// <summary>
        /// The center position within a 3x3 grid.
        /// </summary>
        Center,

        /// <summary>
        /// Represents the top-left position in a nine-cross directional layout.
        /// </summary>
        TopLeft,

        /// <summary>
        /// Represents the top-right position in a 3x3 grid for the `STSNineCross` enumeration.
        /// </summary>
        TopRight,

        /// <summary>
        /// Represents the bottom-left position in a 3x3 grid.
        /// </summary>
        BottomLeft,

        /// <summary>
        /// Represents the bottom-right position in a 3x3 grid for scene transitions.
        /// </summary>
        BottomRight,
    }
}