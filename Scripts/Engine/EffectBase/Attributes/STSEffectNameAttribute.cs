using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Attribute to specify a name for an STS effect.
    /// </summary>
    public class STSEffectNameAttribute : Attribute
    {
        /// <summary>
        /// Represents the name of the effect as a string.
        /// </summary>
        public string EffectName;

        /// <summary>
        /// Attribute to define the name of an effect in the Scene Transition System.
        /// </summary>
        public STSEffectNameAttribute(string sEffectName)
        {
            this.EffectName = sEffectName;
        }
    }
}