using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// The STSTintPrimaryAttribute class is used to designate that a specific effect type
    /// requires a primary tint attribute. This attribute is intended to be used in the
    /// Scene Transition System to add tint customization to effects.
    /// </summary>
    public class STSTintPrimaryAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement or description for various scene transition attributes,
        /// particularly used within the context of tinting attributes such as primary tint.
        /// </summary>
        public string Entitlement = "Tint Primary";

        /// <summary>
        /// Attribute that indicates the primary tint used for a scene transition.
        /// </summary>
        public STSTintPrimaryAttribute()
        {
        }

        /// <summary>
        /// Attribute used to specify that the primary tint should be applied to the annotated target.
        /// </summary>
        public STSTintPrimaryAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}