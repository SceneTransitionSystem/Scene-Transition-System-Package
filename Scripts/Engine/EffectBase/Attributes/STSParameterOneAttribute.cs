using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents an attribute for a parameter in the Scene Transition System (STS).
    /// This attribute can be used to specify the entitlement of the parameter,
    /// whether it should be displayed as a slider, and its minimum and maximum values if applicable.
    /// </summary>
    public class STSParameterOneAttribute : Attribute
    {
        /// <summary>
        /// Represents an entitlement string for the STSParameterOneAttribute class.
        /// </summary>
        public string Entitlement = "Parameter One";

        /// <summary>
        /// Indicates whether the parameter should be represented by a slider with a range,
        /// allowing users to adjust its value between a minimum and maximum limit.
        /// </summary>
        public bool Slider = false;

        /// <summary>
        /// Represents the minimum value for a parameter in the Scene Transition System.
        /// </summary>
        public int Min;

        /// <summary>
        /// Represents the maximum value for a parameter within the Scene Transition System.
        /// </summary>
        public int Max;

        /// <summary>
        /// Represents a custom attribute to define a parameter with an entitlement of "Parameter One".
        /// </summary>
        /// <remarks>
        /// This attribute can be used to designate a specific parameter, optionally with slider settings that include minimum and maximum values.
        /// </remarks>
        public STSParameterOneAttribute()
        {
        }

        /// <summary>
        /// Specifies a customizable parameter for scene transitions with optional slider functionality, minimum, and maximum values.
        /// </summary>
        public STSParameterOneAttribute(string sEntitlement, int sMin, int sMax)
        {
            this.Slider = true;
            this.Entitlement = sEntitlement;
            this.Min = sMin;
            this.Max = sMax;
        }

        /// <summary>
        /// An attribute class used to specify a first parameter in a scene transition system effect.
        /// </summary>
        /// <remarks>
        /// This attribute can be used to define a custom entitlement for the parameter, and optionally
        /// configure it as a slider with a specified minimum and maximum value.
        /// </remarks>
        public STSParameterOneAttribute(string sEntitlement)
        {
            this.Slider = false;
            this.Entitlement = sEntitlement;
        }
    }
}