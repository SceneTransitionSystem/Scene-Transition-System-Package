using UnityEngine;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents a tile in the scene transition system.
    /// </summary>
    public class STSTile
    {
        /// <summary>
        /// Defines a rectangular area within the tile, represented as a UnityEngine.Rect structure.
        /// This property is used to set or get the dimensions and position of the rectangle
        /// associated with the STSTile object, enabling operations like drawing or transforming
        /// rectangular bounds within various scene transition effects.
        /// </summary>
        public Rect Rectangle;

        /// <summary>
        /// Represents the percentage value associated with the STSTile object.
        /// This value is used to determine the proportion or completion level
        /// of the tile's transition or effect within the scene transition system.
        /// </summary>
        public float Purcent;

        /// <summary>
        /// Represents the speed at which a tile in the scene transition system moves.
        /// </summary>
        public float Speed;

        /// <summary>
        /// Specifies the delay before starting the transition for a specific tile.
        /// The delay is calculated based on the tile's position within the matrix
        /// and a given start delay factor, which ensures staggered transitions.
        /// </summary>
        public float StartDelay;
    }
}