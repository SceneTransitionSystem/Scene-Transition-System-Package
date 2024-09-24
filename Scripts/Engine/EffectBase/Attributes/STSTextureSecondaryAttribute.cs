using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// The STSTextureSecondaryAttribute class is used for defining a secondary texture attribute for scene transitions in the Scene Transition System (STS).
    /// </summary>
    public class STSTextureSecondaryAttribute : Attribute
    {
        /// <summary>
        /// Represents the entitlement string used for the secondary texture
        /// in the Scene Transition System.
        /// </summary>
        public string Entitlement = "Texture Secondary";

        /// <summary>
        /// Represents a secondary texture attribute in the scene transition system.
        /// </summary>
        public STSTextureSecondaryAttribute()
        {
        }

        /// <summary>
        /// Attribute to define a secondary texture property.
        /// </summary>
        public STSTextureSecondaryAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}