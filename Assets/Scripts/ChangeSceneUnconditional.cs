using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class ChangeSceneUnconditional : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<PlayableDirector>().state != PlayState.Playing)
        {
            MoveToScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }


}
