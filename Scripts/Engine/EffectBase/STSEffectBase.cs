using System;
using UnityEngine;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents the base class for all scene transition effects in the SceneTransitionSystem namespace.
    /// </summary>
    [Serializable]
    public class STSEffectBase
    {
        //[SerializeField]
        /// <summary>
        /// Name of the visual or transitional effect.
        /// </summary>
        public string EffectName = "";

        /// <summary>
        /// Represents an AnimationCurve used to define the behavior of an animation effect
        /// over time within the Scene Transition System. The curve determines the value
        /// of a property at different points in time, allowing for complex animations.
        /// </summary>
        public AnimationCurve Curve;

        /// <summary>
        /// Represents the primary tint color to be used in various scene transition effects.
        /// </summary>
        /// <remarks>
        /// This color is applied to specific visual elements during transitions.
        /// It is utilized by different transition effects to achieve the desired visual outcome.
        /// Example effects employing this variable include circle drawings, fade animations, and more.
        /// </remarks>
        /// <value>
        /// The default value is Color.black.
        /// </value>
        public Color TintPrimary = Color.black;

        /// <summary>
        /// Represents the secondary tint color used in the transition effect.
        /// This color can be used for blending, gradient transitions, or other visual effects
        /// during scene transitions, providing a secondary color reference to the primary tint color.
        /// </summary>
        public Color TintSecondary = Color.black;

        /// <summary>
        /// Represents the primary texture used in the scene transition effect. This texture
        /// is applied as the main visual element during the transition and can be customized
        /// to fit various transition styles.
        /// </summary>
        public Texture2D TexturePrimary = null;

        /// <summary>
        /// Represents the secondary texture used in the scene transition effect.
        /// This texture provides an additional layer of customization and visual variation
        /// alongside the primary texture.
        /// </summary>
        public Texture2D TextureSecondary = null;

        /// <summary>
        /// Represents the position offset for the effect.
        /// This field is used to adjust the position of the effect within the scene.
        /// </summary>
        public Vector2 Offset;

        /// <summary>
        /// Specifies the type of cross transition effect to be used in the scene transition system.
        /// </summary>
        /// <remarks>
        /// This variable determines whether the cross transition effect will be applied vertically or horizontally.
        /// </remarks>
        public STSTwoCross TwoCross;

        /// <summary>
        /// Represents a four-way cross type effect used in scene transitions.
        /// </summary>
        public STSFourCross FourCross;

        /// <summary>
        /// Represents one of the five possible directions for a cross effect in scene transitions.
        /// </summary>
        /// <remarks>
        /// The FiveCross variable determines the direction or position used for certain scene transition effects.
        /// Possible values include:
        /// - Top
        /// - Bottom
        /// - Right
        /// - Left
        /// - Center
        /// </remarks>
        public STSFiveCross FiveCross;

        /// <summary>
        /// Represents the directional transitions available in the Scene Transition System.
        /// This variable determines which transitional direction (top, bottom, right, left, etc.)
        /// will be used for the animation effect.
        /// </summary>
        public STSEightCross EightCross;

        /// <summary>
        /// Represents the nine-cross transition effect setting in the Scene Transition System.
        /// </summary>
        /// <remarks>
        /// NineCross is a member of the STSEffectBase class and indicates a transition effect characterized
        /// by nine different positions: Top, Bottom, Right, Left, Center, TopLeft, TopRight, BottomLeft, and BottomRight.
        /// This effect can be used to create complex scene transitions by specifying the entry and exit locations
        /// of the transition effect.
        /// </remarks>
        public STSNineCross NineCross;

        /// <summary>
        /// Represents the direction of the effect's animation.
        /// </summary>
        /// <remarks>
        /// This variable indicates whether the animation effect should proceed in a clockwise or counterclockwise direction.
        /// </remarks>
        public STSClockwise Clockwise;

        /// <summary>
        /// Represents a customizable integer parameter for various graphical effects
        /// within the Scene Transition System. This parameter can influence different
        /// aspects of visual transitions, such as intensity, duration, or other effect-specific
        /// attributes.
        /// </summary>
        public int ParameterOne;

        /// <summary>
        /// Represents the number of columns in a grid system used by the scene transition effect.
        /// </summary>
        public int ParameterTwo;

        /// <summary>
        /// Represents an integer parameter used in the scene transition effect.
        /// This parameter is utilized within various scene transition computations
        /// and visual effect adjustments.
        /// </summary>
        public int ParameterThree;

        /// <summary>
        /// Represents the duration of the STS effect in seconds.
        /// </summary>
        public float Duration = 1.0F;

        /// <summary>
        /// Represents the percentage (from 0.0 to 1.0) that indicates the progress of the effect within the Scene Transition System.
        /// </summary>
        public float Purcent = 0.0F;

        /// <summary>
        /// Represents the current value on the animation curve evaluated at the percentage of the transition.
        /// </summary>
        /// <remarks>
        /// This variable is used to determine the interpolated value on the animation curve based on the current transition percentage.
        /// </remarks>
        public float CurvePurcent = 0.0F;

        // Pseudo private... pblic but not in the inspector
        /// <summary>
        /// Represents the direction of the animation progression for a scene transition effect.
        /// 0 indicates an unknown direction.
        /// 1 indicates that the animation progresses from 0.0F to 1.0F percentage.
        /// -1 indicates that the animation progresses from 1.0F to 0.0F percentage.
        /// </summary>
        public int Direction = 0; // 0 is unknow; -1 go from 1.0F to 0.0F purcent; 1 go from 0.0F to 1.0F purcent

        /// <summary>
        /// Represents the percentage of animation completion ranging from 0.0 (start) to 1.0 (complete).
        /// </summary>
        public float AnimPurcent = 0.0F;

        /// <summary>
        /// Indicates whether the animation is currently playing.
        /// </summary>
        public bool AnimIsPlaying = false;

        /// <summary>
        /// Indicates whether the animation has finished playing.
        /// </summary>
        public bool AnimIsFinished = false;


        /// <summary>
        /// Represents the previous color state before the transition effect begins.
        /// </summary>
        public Color OldColor;

        /// <summary>
        /// The duration of the color transition effect.
        /// Used to indicate how long the transition between colors should last.
        /// </summary>
        public float ColorDuration = 0.0F;

        /// <summary>
        /// Represents the percentage completion of a color transition in an effect animation.
        /// A value of 0.0F indicates that the transition has just started, while a value of 1.0F indicates that the transition is complete.
        /// </summary>
        public float ColorPurcent = 0.0F;

        /// <summary>
        /// Indicates whether a color transition effect is currently playing.
        /// </summary>
        public bool ColorIsPlaying = false;

        /// <summary>
        /// Indicates whether the color transition effect has completed.
        /// </summary>
        public bool ColorIsFinished = false;
    }
}