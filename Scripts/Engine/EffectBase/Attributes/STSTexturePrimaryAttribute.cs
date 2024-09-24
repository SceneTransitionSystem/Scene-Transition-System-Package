using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// An attribute used to mark a primary texture for a scene transition effect in the Scene Transition System.
    /// </summary>
    public class STSTexturePrimaryAttribute : Attribute
    {
        /// <summary>
        /// The <c>Entitlement</c> variable signifies the entitlement or designation specific to a texture attribute in the Scene Transition System.
        /// This variable is instrumental in customization and identification of primary texture usage within the system's attribute classes.
        /// </summary>
        public string Entitlement = "Texture Primary";

        /// <summary>
        /// Defines an attribute for specifying a primary texture in a Scene Transition System effect.
        /// </summary>
        public STSTexturePrimaryAttribute()
        {
        }

        /// <summary>
        /// Represents a primary texture attribute for scene transition effects.
        /// </summary>
        public STSTexturePrimaryAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}