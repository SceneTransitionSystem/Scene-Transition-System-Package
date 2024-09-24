using System;

namespace SceneTransitionSystem
{
    /// <summary>
    /// An attribute to specify that an effect should be rendered in a clockwise manner.
    /// </summary>
    public class STSClockwiseAttribute : Attribute
    {
        /// <summary>
        /// The Entitlement variable represents the directional attribute of a scene transition effect.
        /// It is primarily used in the context of attribute classes within the SceneTransitionSystem to
        /// denote the direction of a transition, such as "Clockwise".
        /// The Entitlement variable can be set to either "Clockwise" or "Counterclockwise".
        /// </summary>
        public string Entitlement = "Clockwise";

        /// <summary>
        /// An attribute used to denote that an effect operates in a clockwise direction.
        /// It can be applied to classes to specify that they should execute their functionality in a clockwise manner.
        /// </summary>
        public STSClockwiseAttribute()
        {
        }

        /// <summary>
        /// The STSClockwiseAttribute class is an attribute that indicates the direction
        /// of a specific effect or animation as clockwise. It contains an entitlement field
        /// that can be customized via constructors to specify the desired direction.
        /// </summary>
        public STSClockwiseAttribute(string sEntitlement)
        {
            this.Entitlement = sEntitlement;
        }
    }
}