using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Attribute class used to designate secondary tinting for scene transitions.
    /// </summary>
    public class STSTintSecondaryAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement description associated with the secondary tint in an STSTintSecondaryAttribute.
        /// </summary>
        public string Entitlement = "Tint Secondary";

        /// <summary>
        /// Defines an attribute to specify a secondary tint color for scene transitions.
        /// </summary>
        /// <remarks>
        /// The secondary tint is represented by the `Entitlement` property, which can be set
        /// through the constructor.
        /// </remarks>
        public STSTintSecondaryAttribute()
        {
        }

        /// <summary>
        /// Attribute to define a secondary tint for scene transitions.
        /// </summary>
        public STSTintSecondaryAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}