using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Attribute to mark effects with the "Eight cross" entitlement in the Scene Transition System.
    /// </summary>
    public class STSEightCrossAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement description for an STSEightCrossAttribute.
        /// </summary>
        public string Entitlement = "Eight cross";

        /// <summary>
        /// Attribute indicating an "Eight Cross" effect in the Scene Transition System.
        /// </summary>
        public STSEightCrossAttribute()
        {
        }

        /// <summary>
        /// An attribute representing an eight-cross effect in the scene transition system.
        /// </summary>
        public STSEightCrossAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}