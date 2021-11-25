using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Pause Game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
        }

        // play in slowmotion
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0.25f;
        }

        // play Game
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }
    }
}
