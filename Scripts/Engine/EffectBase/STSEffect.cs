using UnityEngine;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents a scene transition effect within the Scene Transition System.
    /// </summary>
    [STSEffectName("Default effect")]
    // *** Remove some parameters in inspector
    // No remove
    // ***
    public class STSEffect : STSEffectType
    {
        /// <summary>
        /// Estimates the percentage value based on an animation curve.
        /// </summary>
        /// <remarks>
        /// This method assigns the evaluated value of the animation curve at the current percentage to the CurvePurcent field.
        /// </remarks>
        public void EstimateCurvePurcent()
        {
            CurvePurcent = Curve.Evaluate(Purcent);
        }

        /// <summary>
        /// Estimates the animation percentage (AnimPurcent) based on the elapsed time and the effect's duration.
        /// Updates the Purcent field based on AnimPurcent and the direction of the animation.
        /// </summary>
        public void EstimatePurcent()
        {
            if (AnimPurcent < 1.0F || AnimPurcent >= 0.0F)
            {
                AnimPurcent += (Time.deltaTime) / Duration;
                if (AnimPurcent > 1.0F)
                {
                    AnimPurcent = 1.0F;
                    //AnimIsPlaying = false;
                    AnimIsFinished = true;
                }

                if (AnimPurcent < 0.0F)
                {
                    // IMPOSSIBLE
                    AnimPurcent = 0.0F;
                    //AnimIsPlaying = false;
                    AnimIsFinished = true;
                }
            }

            switch (Direction)
            {
                case 0:
                    // no direction do nothing ... on error
                    break;
                case 1:
                    Purcent = AnimPurcent;
                    break;
                case -1:
                    Purcent = 1 - AnimPurcent;
                    break;
            }
            //Debug.Log("STSEffect EstimatePurcent() => AnimPurcent = " + AnimPurcent.ToString("F3"));
            //Debug.Log("STSEffect EstimatePurcent() => Purcent = " + Purcent.ToString("F3"));
        }

        /// <summary>
        /// Initiates the start of the effect entering transition with specified parameters. Handles the preparation and color transition, ensuring
        /// the state is set to play the effect animation.
        /// </summary>
        /// <param name="sRect">The rectangular region where the effect is applied.</param>
        /// <param name="sOldColor">The initial color before the transition effect starts.</param>
        /// <param name="sInterEffectDelay">The delay before the effect starts transitioning.</param>
        /// <param name="sEffectMoreInfos">Additional information related to the transition effect.</param>
        public void StartEffectEnter(Rect sRect, Color sOldColor, float sInterEffectDelay, STSEffectMoreInfos sEffectMoreInfos)
        {
            PrepareEffectEnter(sRect);
            ColorIsPlaying = false;
            if (sInterEffectDelay > 0)
            {
                // I need do to a color transitionpublic float 
                ColorPurcent = 0.0F;
                ColorDuration = sInterEffectDelay;
                OldColor = sOldColor;
                ColorIsPlaying = true;
                ColorIsFinished = false;
            }
            else
            {
                ColorIsFinished = true;
            }

            AnimPurcent = 0.0F;
            Direction = -1;
            AnimIsPlaying = true;
            AnimIsFinished = false;
        }

        /// <summary>
        /// Initiates the exit animation effect for a scene transition.
        /// </summary>
        /// <param name="sRect">The dimensions of the effect area.</param>
        /// <param name="sEffectMoreInfos">Additional information related to the effect.</param>
        public void StartEffectExit(Rect sRect, STSEffectMoreInfos sEffectMoreInfos)
        {
            PrepareEffectExit(sRect);
            AnimPurcent = 0.0F;
            Direction = 1;
            AnimIsPlaying = true;
            AnimIsFinished = false;
        }

        /// <summary>
        /// Pauses the current effect animation.
        /// </summary>
        /// <remarks>
        /// This method stops the ongoing animation but does not reset its progress.
        /// It can be resumed from the same point at a later time.
        /// </remarks>
        public void PauseEffect()
        {
            AnimIsPlaying = false;
        }

        /// <summary>
        /// Stops the current effect, setting its animation percentage to 100%,
        /// marking it as finished, and stopping any ongoing animation.
        /// </summary>
        public void StopEffect()
        {
            AnimPurcent = 1.0F;
            AnimIsPlaying = false;
            AnimIsFinished = true;
        }

        /// Resets the transition effect to its initial state.
        /// This method sets the animation percentage to zero and resets the direction,
        /// playing, and finished status flags to their default values. Use this method
        /// to restart or reset the effect before beginning a new transition.
        /// /
        public void ResetEffect()
        {
            AnimPurcent = 0.0F;
            Direction = 0;
            AnimIsPlaying = false;
            AnimIsFinished = false;
        }

        /// <summary>
        /// Draws the master effect, handling both color transition and animation.
        /// </summary>
        /// <param name="sRect">The rectangle area to draw within.</param>
        public void DrawMaster(Rect sRect)
        {
            //if (Event.current.type.Equals(EventType.Repaint))
            //{
            // Do drawing
            if (ColorIsFinished == false)
            {
                ColorPurcent += (Time.deltaTime) / ColorDuration;
                Color tColor = Color.Lerp(OldColor, TintPrimary, ColorPurcent);
                STSDrawQuad.DrawRect(sRect, tColor);
                if (ColorPurcent >= 1)
                {
                    ColorIsPlaying = false;
                    ColorIsFinished = true;
                }
            }
            else
            {
                if (AnimIsPlaying == true) // play animation
                {
                    // estimate purcent
                    EstimatePurcent();
                    //EstimateCurvePurcent();
                    Draw(sRect);
                }
            }
            //}
        }

        /// <summary>
        /// Prepares the effect's initial state before it starts entering.
        /// </summary>
        /// <param name="sRect">The rectangle area where the effect will be drawn.</param>
        public virtual void PrepareEffectEnter(Rect sRect)
        {
            // Prepare your datas to draw
        }

        /// <summary>
        /// Prepares the effect for exiting the scene transition. This method is intended to be overridden
        /// by derived classes to set up the necessary data for rendering the exit effect.
        /// </summary>
        /// <param name="sRect">The rectangle defining the area of the screen for the exit effect.</param>
        public virtual void PrepareEffectExit(Rect sRect)
        {
            // Prepare your datas to draw
        }

        /// <summary>
        /// Draws the effect within the specified rectangle.
        /// </summary>
        /// <param name="sRect">The rectangle area where the effect will be drawn.</param>
        public virtual void Draw(Rect sRect)
        {
            // Do drawing with purcent
        }
    }
}