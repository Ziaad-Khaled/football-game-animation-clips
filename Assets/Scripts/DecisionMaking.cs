using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class DecisionMaking : MonoBehaviour
{
    public GameObject runningSceneCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<PlayableDirector>().state != PlayState.Playing)
        {
            runningSceneCanvas.SetActive(true);
            //Play Audio Source of decision
        }
    }
    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CrossOnGround()
    {
        MoveToScene("GroundCrossingScene");
    }

    public void CrossAboveGround()
    {
        MoveToScene("AirCrossingScene");
    }
}
