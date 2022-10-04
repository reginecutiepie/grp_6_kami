using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject videoPlayerGO;
    public VideoClip winnervid;

    void Start()
    {
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = winnervid;
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
    }

    public void backTofightinggame()
    {
        SceneManager.LoadScene(1);
    }

    public void backTomenu()
    {
        SceneManager.LoadScene(0);
    }

    
}
