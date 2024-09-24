namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents different debug colors used for logging in the Scene Transition System.
    /// </summary>
    public enum STSSceneDebugColor
    {
        /// <summary>
        /// Specifies the debug color as black for logging purposes in the Scene Transition System.
        /// </summary>
        black,

        /// <summary>
        /// Specifies the debug color as red for logging purposes in the Scene Transition System.
        /// </summary>
        red,

        /// <summary>
        /// Represents the green color option for debugging scene transitions.
        /// When the <see cref="STSSceneController.ActiveLog"/> is set to true and this color is selected,
        /// debug messages will be displayed in green within the Unity console.
        /// </summary>
        green,

        /// <summary>
        /// Represents debug colors for the scene transition system.
        /// </summary>
        yellow,

        /// <summary>
        /// Represents the color blue for debugging purposes within the scene transition system.
        /// </summary>
        blue,

        /// <summary>
        /// Represents the gray color option for scene debug logging.
        /// </summary>
        gray,
    }
}