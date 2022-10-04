using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class menuScript : MonoBehaviour
{

    public GameObject bgVD;
    public VideoClip background;

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        bgVD.gameObject.GetComponent<VideoPlayer>().clip = background;
        bgVD.gameObject.GetComponent<VideoPlayer>().Play();
    }
}
