using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{

    public GameObject videoPlayerGO;
    public VideoClip loservid;

    void Start()
    {
        videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = loservid;
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
