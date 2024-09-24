using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// The STSFiveCrossAttribute class is a custom attribute utilized within the SceneTransitionSystem.
    /// This attribute signifies that the associated effect type has a "Five cross" entitlement.
    /// </summary>
    public class STSFiveCrossAttribute : Attribute
    {
        /// <summary>
        /// The <c>Entitlement</c> field represents a descriptive string associated with the
        /// <c>STSFiveCrossAttribute</c> class, typically used to provide a label or identifier
        /// for the attribute when applied to an element in the Scene Transition System.
        /// </summary>
        public string Entitlement = "Five cross";

        /// <summary>
        /// Represents an attribute that denotes a five-cross configuration.
        /// </summary>
        public STSFiveCrossAttribute()
        {
        }

        /// <summary>
        /// Represents an attribute for the "Five cross" effect in the Scene Transition System.
        /// </summary>
        public STSFiveCrossAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}