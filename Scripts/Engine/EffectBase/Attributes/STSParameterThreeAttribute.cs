using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Defines an attribute for a parameter in the Scene Transition System (STSEffectType).
    /// </summary>
    public class STSParameterThreeAttribute : Attribute
    {
        /// <summary>
        /// The entitlement string used within the STSParameterThreeAttribute class.
        /// Represents a description or label for what the third parameter is intended to control or signify.
        /// </summary>
        public string Entitlement = "Parameter Three";

        /// This boolean variable determines whether a slider control is used for the parameter.
        /// When set to true, the parameter will be represented with a slider for user input.
        /// When set to false, the parameter will be represented without a slider.
        public bool Slider = false;

        /// <summary>
        /// The minimum value for the parameter in the STSParameterThreeAttribute class.
        /// </summary>
        public int Min;

        /// <summary>
        /// Represents the maximum value for the third parameter of an STS effect.
        /// </summary>
        public int Max;

        /// <summary>
        /// Attribute to define a customizable parameter for a scene transition system.
        /// Provides an option to specify a slider with minimum and maximum values.
        /// </summary>
        public STSParameterThreeAttribute()
        {
        }

        /// <summary>
        /// Custom attribute used for defining parameters in the scene transition system.
        /// This attribute is specifically for "Parameter Three" and allows configuration
        /// of its properties such as entitlement, minimum value, and maximum value.
        /// </summary>
        public STSParameterThreeAttribute(string sEntitlement, int sMin, int sMax)
        {
            this.Slider = true;
            this.Entitlement = sEntitlement;
            this.Min = sMin;
            this.Max = sMax;
        }

        /// <summary>
        /// An attribute used to denote a third configurable parameter in an effect.
        /// </summary>
        /// <remarks>
        /// This attribute allows for the specification of a third parameter, which can be configured with optional minimum and maximum values if a slider is required.
        /// </remarks>
        public STSParameterThreeAttribute(string sEntitlement)
        {
            this.Slider = false;
            this.Entitlement = sEntitlement;
        }
    }
}