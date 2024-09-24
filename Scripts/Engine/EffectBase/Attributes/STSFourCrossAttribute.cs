using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// An attribute class used to designate effects that involve a four-cross pattern
    /// in the Scene Transition System.
    /// </summary>
    public class STSFourCrossAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement string associated with an STSFourCrossAttribute.
        /// This is used in the Scene Transition System to specify additional metadata or descriptive information
        /// for effects that utilize the four-cross transition.
        /// </summary>
        public string Entitlement = "Four cross";

        /// <summary>
        /// Represents an attribute for defining a four cross effect in the Scene Transition System.
        /// </summary>
        public STSFourCrossAttribute()
        {
        }

        /// <summary>
        /// Attribute to specify four cross entitlement for scene transitions.
        /// </summary>
        /// <remarks>
        /// This attribute can be used to tag properties or fields that involve
        /// transitions in four directions (Top, Bottom, Right, Left).
        /// </remarks>
        public STSFourCrossAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}