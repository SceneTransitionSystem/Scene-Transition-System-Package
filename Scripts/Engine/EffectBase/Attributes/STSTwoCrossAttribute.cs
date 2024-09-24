using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// An attribute used to mark a field or property for special handling within
    /// the Scene Transition System. Specifically, it denotes that the element
    /// is associated with a "Two Cross" transition effect.
    /// </summary>
    public class STSTwoCrossAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement related to the STSTwoCrossAttribute.
        /// </summary>
        public string Entitlement = "Orientation";

        /// <summary>
        /// Represents an attribute that specifies a two-orientation cross, used for defining the orientation
        /// (Vertical or Horizontal) in a scene transition system.
        /// </summary>
        public STSTwoCrossAttribute()
        {
        }

        /// <summary>
        /// Specifies an orientation for a 2-cross attribute.
        /// </summary>
        /// <remarks>
        /// This attribute is used to define a horizontal or vertical orientation.
        /// Default entitlement is "Orientation".
        /// </remarks>
        public STSTwoCrossAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}