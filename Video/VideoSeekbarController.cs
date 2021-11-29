using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class VideoSeekbarController : MonoBehaviour
{

    public VideoPlayer video;
    public Slider slider;

    public bool IsPrepared
    {
        get { return video.isPrepared; }
    }
    public double Time
    {
        get { return video.time; }
    }

    public ulong Duration
    {
        get { return (ulong)(video.frameCount / video.frameRate); }
    }

    public double NTime
    {
        get { return Time / Duration; }
    }
    void Update()
    {
        if (!IsPrepared) return;

        slider.value = (float)NTime;


    }
    public void Seek(float nTime)
    {
        if (!video.canSetTime) return;
        if (!IsPrepared) return;
        nTime = Mathf.Clamp(nTime, 0, 1);
        video.time = nTime * Duration;
    }

}