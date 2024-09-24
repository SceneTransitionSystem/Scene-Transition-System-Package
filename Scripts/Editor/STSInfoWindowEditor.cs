using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Linq;
using System.IO;
using System.Reflection;

namespace SceneTransitionSystem
{
public class STSInfoWindowEditor : EditorWindow
{
    // Contenu de la fenêtre
        private string moduleName = "Nom du Module";
        private string moduleVersion = "v1.0.0";
        private string description = "Description de ton module ici.";
    
        // Ajouter un élément de menu pour ouvrir la fenêtre
        [MenuItem("Window/Scene Transition System")]
        public static void ShowWindow()
        {
            // Créer et afficher la fenêtre
            var window = GetWindow<STSInfoWindowEditor>("Module Info");
            window.Show();
        }
        private bool IsAssemblyLoaded(string assemblyName)
            {
                // Récupère toutes les assemblies chargées dans l'application
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        
                // Vérifie si une assembly correspond au nom donné
                return assemblies.Any(assembly => assembly.GetName().Name.Equals(assemblyName, StringComparison.OrdinalIgnoreCase));
            }
    
        // Cette méthode dessine le contenu de la fenêtre
        private void OnGUI()
        {
            // Affiche les informations dans la fenêtre
            GUILayout.Label("Informations du module", EditorStyles.boldLabel);
            GUILayout.Label($"Nom : {moduleName}");
            GUILayout.Label($"Version : {moduleVersion}");
            GUILayout.Label($"Description : {description}");
            
            // on va afficher un lien vers le site de documentation
            
            // on va afficher un lien vers l'asset store pour revoir le module 
            
            // on va afficher si les addressable sont supprorté ou non et afficher un bouton vers le module
            if (IsAssemblyLoaded("SceneTransitionSystemAddressableAssembly"))
                {
                    
            GUILayout.Label("SceneTransitionSystemAddressableAssembly installed");
                    }
                else
                    
                    {
            GUILayout.Label("SceneTransitionSystemAddressableAssembly not installed go to asset store");
                        }
            
            // on va afficher les packs et s'ils sont installés ou non
            if (IsAssemblyLoaded("SceneTransitionSystemPackOne"))
                {
                    
            GUILayout.Label("SceneTransitionSystemPackOne installed");
                    }
                else
                    
                    {
            GUILayout.Label("SceneTransitionSystemPackOne not installed go to asset store");
                        }
            if (IsAssemblyLoaded("SceneTransitionSystemPackTwo"))
                {
                    
            GUILayout.Label("SceneTransitionSystemPackTwo installed");
                    }
                else
                    
                    {
            GUILayout.Label("SceneTransitionSystemPackTwo not installed go to asset store");
                        }
            
            // Ajouter éventuellement des boutons ou d'autres éléments GUI
            if (GUILayout.Button("Fermer"))
            {
                this.Close();
            }
        }
}
}