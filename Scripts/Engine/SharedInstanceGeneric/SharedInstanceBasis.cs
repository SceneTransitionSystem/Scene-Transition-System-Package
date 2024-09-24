using UnityEngine;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Base class for shared instances within the Scene Transition System.
    /// </summary>
    public class SharedInstanceBasis : MonoBehaviour
    {
        /// <summary>
        /// Indicates whether the shared instance has been initialized.
        /// </summary>
        public bool Initialized = false;

        /// <summary>
        /// Initializes the instance of the shared basis class.
        /// Must be overridden in derived classes to provide specific initialization logic.
        /// </summary>
        public virtual void InitInstance()
        {
        }
    }
}