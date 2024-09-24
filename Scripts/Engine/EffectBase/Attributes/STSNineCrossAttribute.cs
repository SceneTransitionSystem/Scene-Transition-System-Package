using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// This attribute is used to designate a class or method that pertains to the "Nine cross" effect
    /// in the Scene Transition System.
    /// </summary>
    public class STSNineCrossAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement associated with the STSNineCrossAttribute,
        /// used to specify or override the nine cross textual description in the
        /// Scene Transition System.
        /// </summary>
        /// <remarks>
        /// The Entitlement property can be used to provide a custom textual representation
        /// for the nine cross when applied in a scene transition effect.
        /// </remarks>
        public string Entitlement = "Nine cross";

        /// An attribute that signifies the use of a "Nine cross" pattern.
        /// This attribute can be used to denote an effect or transition that
        /// involves nine distinct sections or areas (typically: Top, Bottom,
        /// Right, Left, Center, TopLeft, TopRight, BottomLeft, BottomRight).
        /// The default entitlement is "Nine cross".
        /// Constructors:
        /// STSNineCrossAttribute() - Initializes with the default entitlement.
        /// STSNineCrossAttribute(string sEntitlement) - Initializes with a
        /// specified entitlement.
        public STSNineCrossAttribute()
        {
        }

        /// <summary>
        /// Represents a custom attribute for an effect with a "Nine cross" pattern.
        /// This attribute allows customization of the effect by specifying an entitlement string.
        /// </summary>
        public STSNineCrossAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}