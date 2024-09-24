using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// An attribute used to indicate an offset entitlement for scene transition effects.
    /// </summary>
    public class STSOffsetAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement attribute for the STSOffsetAttribute class.
        /// This variable holds a string value that serves as the label or identifier
        /// for the offset attribute in the scene transition system.
        /// It is utilized to customize the display and behavior of the offset property
        /// in the Unity editor.
        /// </summary>
        public string Entitlement = "Offset";

        /// <summary>
        /// An attribute to specify entitlement for an offset in the Scene Transition System (STS).
        /// </summary>
        public STSOffsetAttribute()
        {
        }

        /// <summary>
        /// Represents an attribute used to define an offset property in the scene transition system.
        /// </summary>
        public STSOffsetAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}