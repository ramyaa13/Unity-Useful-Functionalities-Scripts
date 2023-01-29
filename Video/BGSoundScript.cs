using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGSoundScript : MonoBehaviour
{

    bool x = true;
    public Button MusicOn;
    public Sprite MusicOnSprite;
    public Sprite MusicOffSprite;
    // Use this for initialization
    void Start()
    {

    }

    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    public void GameMusicControl()
    {
        if (x == true)
        {
            BGSoundScript.instance.gameObject.GetComponent<AudioSource>().Pause();
            MusicOn.GetComponent<Image>().sprite = MusicOffSprite;
            x = false;
        }
        else
        {
            BGSoundScript.instance.gameObject.GetComponent<AudioSource>().Play();
            MusicOn.GetComponent<Image>().sprite = MusicOnSprite;
            x = true;
        }
    }
}