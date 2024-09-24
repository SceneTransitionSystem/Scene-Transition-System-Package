using System.Collections;
using System.Collections.Generic;
using SceneTransitionSystem;
using UnityEngine;
using UnityEngine.Events;

public class STSDemoController : MonoBehaviour
{
    public void  GotToScene(STSScene sScene)
    {
        STSSceneManager.LoadScene(sScene.GetSceneShortName());
    }
    public void  GotToSceneA()
    {
        Debug.Log("click on to go scene A");
        STSSceneManager.LoadScene("SceneA");
    }
    public void  GotToSceneB()
    {
        Debug.Log("click on to go scene B");
        STSSceneManager.LoadScene("SceneB");
    }
    public void  GotToSceneC()
    {
        Debug.Log("click on to go scene C");
        STSSceneManager.LoadScene("SceneC");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
