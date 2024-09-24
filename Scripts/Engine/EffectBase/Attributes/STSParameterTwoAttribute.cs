using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// The STSParameterTwoAttribute class is an attribute used in the SceneTransitionSystem namespace
    /// to define metadata for scene transition effects. It allows specifying an entitlement or name
    /// for the attribute and optionally configures it as a slider with minimum and maximum values.
    /// </summary>
    public class STSParameterTwoAttribute : Attribute
    {
        /// <summary>
        /// Represents a descriptive title or label, often used to identify or name a specific parameter or feature in the UI.
        /// </summary>
        public string Entitlement = "Parameter Two";

        /// <summary>
        /// Indicates whether the parameter should be represented as a slider.
        /// </summary>
        public bool Slider = false;

        /// <summary>
        /// The minimum value for the parameter in the scene transition effect.
        /// </summary>
        public int Min;

        /// <summary>
        /// Represents the maximum value for the parameter.
        /// </summary>
        public int Max;

        /// <summary>
        /// Represents an attribute for applying a secondary parameter with optional slider UI and entitlement.
        /// </summary>
        public STSParameterTwoAttribute()
        {
        }

        /// <summary>
        /// Attribute to define parameters for a custom transition effect with additional configurations like sliders and value ranges.
        /// </summary>
        public STSParameterTwoAttribute(string sEntitlement, int sMin, int sMax)
        {
            this.Slider = true;
            this.Entitlement = sEntitlement;
            this.Min = sMin;
            this.Max = sMax;
        }

        /// <summary>
        /// Attribute representing the second parameter for a scene transition effect.
        /// </summary>
        public STSParameterTwoAttribute(string sEntitlement)
        {
            this.Slider = false;
            this.Entitlement = sEntitlement;
        }
    }
}