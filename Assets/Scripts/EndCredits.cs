using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndCredits : MonoBehaviour
{

    VideoPlayer credits;

    void Awake()
    {
        credits = GetComponent<VideoPlayer>();
        //play the credits
        credits.Play();

        //is the credits ready to loop? call the checkover function 
        credits.loopPointReached += CheckOver;


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        //Debug.Log("Bye For Now :3");

        //quit the game
        Application.Quit();
    }
}

