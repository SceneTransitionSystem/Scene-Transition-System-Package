using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace SceneTransitionSystem
{
    /// <summary>
    /// Represents a type of effect in the Scene Transition System.
    /// </summary>
    [Serializable]
    public class STSEffectType : STSEffectBase
    {
        private static List<Type> EffectList = new List<Type>();

        public static void AddToEffectList<T>() where T : STSEffect
        {
            // Debug.Log("Add effect " + typeof(T).Name + " to list");
            EffectList.Add(typeof(T));
        }

        /// <summary>
        /// List to store GUI content for different types of scene transition effects.
        /// </summary>
        public static List<GUIContent> kEffectContentList = new List<GUIContent>();

        /// <summary>
        /// A list containing the types of effects used in the Scene Transition System (STS).
        /// </summary>
        public static List<Type> kEffectTypeList = new List<Type>();

        /// <summary>
        /// A static list that contains the names of all effects available in the
        /// Scene Transition System (STS).
        /// Intended to be used for effect selection and referencing.
        /// </summary>
        public static List<string> kEffectNameList = new List<string>();

        /// <summary>
        /// The default effect type used for scene transitions within the Scene Transition System (STS).
        /// It initializes with a 'Fade basic' effect, black color, and a duration of 1.0 seconds.
        /// </summary>
        public static STSEffectType Default = new STSEffectType(STSEffectFade.K_FADE_NAME, Color.black, 1.0F);

        /// <summary>
        /// A static instance of the <see cref="STSEffectType"/> class with predefined settings for quick default effects.
        /// </summary>
        public static STSEffectType QuickDefault = new STSEffectType(STSEffectFade.K_FADE_NAME, Color.black, 0.50F);

        /// <summary>
        /// A predefined effect type in the scene transition system representing a "flash" effect.
        /// </summary>
        public static STSEffectType Flash = new STSEffectType(STSEffectFade.K_FADE_NAME, Color.white, 0.50F);

        /// <summary>
        /// Represents the base class for scene transition effects, providing common attributes and methods for manipulating
        /// various effect parameters such as color, texture, and curves used in animations.
        /// </summary>
        public STSEffectType()
        {
            Curve = AnimationCurve.Linear(0.0F, 0.0F, 1.0F, 1.0F);
        }

        /// <summary>
        /// Retrieves an instance of the associated effect based on the effect name.
        /// </summary>
        /// <returns>
        /// An instance of <see cref="STSEffect"/>. If the effect name is not found in the list of known effects,
        /// a default effect of type <see cref="STSEffectFade"/> is returned.
        /// </returns>
        public STSEffect GetEffect()
        {
            STSEffect rReturn = null;
            int tIndex = STSEffectType.kEffectNameList.IndexOf(EffectName);
            if (tIndex < 0 || tIndex >= STSEffectType.kEffectNameList.Count())
            {
                rReturn = new STSEffectFade();
            }
            else
            {
                Type tEffectType = STSEffectType.kEffectTypeList[tIndex];
                rReturn = (STSEffect)Activator.CreateInstance(tEffectType);
                // Copy Param
                rReturn.CopyFrom(this);
            }

            return rReturn;
        }

        /// <summary>
        /// Represents a class for scene transition effects in the SceneTransitionSystem namespace.
        /// </summary>
        public STSEffectType(string sString, Color sColor, float sDuration)
        {
            EffectName = sString;
            TintPrimary = sColor;
            Duration = sDuration;
        }

        /// <summary>
        /// Represents a type of scene transition effect within the Scene Transition System (STS).
        /// </summary>
        public STSEffectType(STSEffectType sObject)
        {
            CopyFrom(sObject);
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="STSEffectType"/> object.
        /// </summary>
        /// <returns>A new <see cref="STSEffectType"/> object that is a copy of the current instance.</returns>
        public STSEffectType Dupplicate()
        {
            STSEffectType tCopy = new STSEffectType(this);
            return tCopy;
        }

        /// <summary>
        /// Copies the properties from another STSEffectType instance to the current instance.
        /// </summary>
        /// <param name="sObject">The STSEffectType object from which to copy the properties.</param>
        public void CopyFrom(STSEffectType sObject)
        {
            EffectName = sObject.EffectName;
            TintPrimary = sObject.TintPrimary;
            TintSecondary = sObject.TintSecondary;
            TexturePrimary = sObject.TexturePrimary;
            TextureSecondary = sObject.TextureSecondary;

            ParameterOne = sObject.ParameterOne;
            ParameterTwo = sObject.ParameterTwo;
            ParameterThree = sObject.ParameterThree;

            TwoCross = sObject.TwoCross;
            FourCross = sObject.FourCross;
            FiveCross = sObject.FiveCross;
            EightCross = sObject.EightCross;
            NineCross = sObject.NineCross;

            Clockwise = sObject.Clockwise;

            Duration = sObject.Duration;
            Purcent = sObject.Purcent;
            if (sObject.Curve != null)
            {
                Curve = new AnimationCurve(sObject.Curve.keys);
            }
            else
            {
                Curve = AnimationCurve.Linear(0.0F, 0.0F, 1.0F, 1.0F);
            }
        }

        
        static private List<Type> GetAllType()
        {
    // on peut ameliorer en limitant aux assemblies qui commmence par SceneTransitionSyste
            List<Type> rReturn = new List<Type>();
            var tAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assembly.GetName().Name.StartsWith("SceneTransitionSystem"));

            foreach (var tAssembly in tAssemblies)
            {
                Type[] tAllTypes = tAssembly.GetTypes();
                Type[] tAllNWDTypes = (from System.Type type in tAllTypes
                     where type.IsSubclassOf(typeof(STSEffect))
                     select type).ToArray();
                rReturn.AddRange(tAllNWDTypes);
            }

            return rReturn;
        }
        /// <summary>
        /// Represents a scene transition effect type in the Scene Transition System.
        /// </summary>
        static STSEffectType()
        {
            // reccord all the effect type
            foreach (Type tType in GetAllType())
            {
                string tEntitlement = tType.Name;
                if (tType.GetCustomAttributes(typeof(STSEffectNameAttribute), true).Length > 0)
                {
                    foreach (STSEffectNameAttribute tReference in tType.GetCustomAttributes(typeof(STSEffectNameAttribute), true))
                    {
                        tEntitlement = tReference.EffectName;
                    }
                }
                if (string.IsNullOrEmpty(tEntitlement))
                {
                    tEntitlement = tType.Name;
                }
                //MethodInfo tMethodInfo = tType.GetMethod("EffectName", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                //if (tMethodInfo != null)
                //{
                //    tEntitlement = tMethodInfo.Invoke(null, null) as string;
                //}
                kEffectContentList.Add(new GUIContent(tEntitlement));
                kEffectTypeList.Add(tType);
                kEffectNameList.Add(tEntitlement);
            }

            // Add Default
            kEffectNameList.Insert(0, "");
            kEffectTypeList.Insert(0, typeof(STSEffectFade));
            kEffectContentList.Insert(0, new GUIContent("Default"));
        }

        /// <summary>
        /// Defines explicit conversion from a UnityEngine.Object to an STSEffectType object.
        /// </summary>
        /// <param name="v">The UnityEngine.Object to be converted.</param>
        /// <returns>The converted STSEffectType object.</returns>
        /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
        public static explicit operator STSEffectType(UnityEngine.Object v)
        {
            throw new NotImplementedException();
        }
    }
}