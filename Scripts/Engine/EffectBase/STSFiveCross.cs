namespace SceneTransitionSystem
{
    /// <summary>
    /// Specifies the directions for the five-cross transition in the Scene Transition System.
    /// </summary>
    public enum STSFiveCross : int
    {
        /// <summary>
        /// Represents the top position in a five-cross configuration for scene transitions.
        /// </summary>
        Top,

        /// <summary>
        /// Represents the bottom position in a five-directional cross pattern.
        /// </summary>
        Bottom,

        /// <summary>
        /// The Right position for the STSFiveCross enumeration.
        /// Indicates an effect starting point or orientation towards the right side.
        /// </summary>
        Right,

        /// <summary>
        /// Enum member representing the left direction in the STSFiveCross enumeration.
        /// </summary>
        Left,

        /// <summary>
        /// Represents the center position in the STSFiveCross enumeration.
        /// </summary>
        Center,
    }
}