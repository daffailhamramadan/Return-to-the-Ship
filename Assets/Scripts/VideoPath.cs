using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPath : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "skyrim.mp4");
    }

}
