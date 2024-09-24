using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneTransitionSystem
{
    /// <summary>
    /// The STSSingletonBasis class serves as a base class for creating singleton behaviors
    /// within the SceneTransitionSystem namespace. It provides methods to manage lifecycle
    /// events and ensure only one instance exists across scenes.
    /// </summary>
    public class STSSingletonBasis : MonoBehaviour
    {
        /// <summary>
        /// Indicates whether the singleton instance has been initialized.
        /// Set to true after the instance is initialized to ensure initialization
        /// occurs only once.
        /// </summary>
        public bool Initialized = false;

        /// <summary>
        /// Determines the root type to be destroyed for the singleton instance.
        /// </summary>
        /// <returns>
        /// A value of type <see cref="STSSingletonRoot"/> indicating whether the GameObject or the Component should be destroyed.
        /// </returns>
        public virtual STSSingletonRoot DestroyRoot()
        {
            return STSSingletonRoot.Component;
        }

        /// <summary>
        /// Initializes the instance of the singleton. This method is typically overridden to include
        /// any specific initialization logic required for the singleton instance.
        /// </summary>
        public virtual void InitInstance()
        {
        }

        /// <summary>
        /// Called when a new scene is loaded. This method can be overridden to implement custom behavior
        /// that should occur whenever a scene is loaded.
        /// </summary>
        /// <param name="sScene">The scene that was loaded.</param>
        /// <param name="sMode">The mode in which the scene was loaded.</param>
        public virtual void OnSceneLoaded(Scene sScene, LoadSceneMode sMode)
        {
        }

        /// <summary>
        /// Handles the actions needed to be performed when a scene is unloaded.
        /// </summary>
        /// <param name="sScene">The scene that has been unloaded.</param>
        public virtual void OnSceneUnLoaded(Scene sScene)
        {
        }
    }
}