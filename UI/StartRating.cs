using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartRating : MonoBehaviour
{
    public int Rate;
    public Image[] starsToFill;
    bool x = false;
    float t;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FillStars();
        }

        if (x == true)
        {
            t += Time.deltaTime;
            // Debug.Log(t);


            if (t > 0.85f)
            {
                t = 0;
                starsToFill[i].gameObject.SetActive(true);
                i = i + 1;
                Debug.Log(i + "time" + t);
            }

        }
        if (i > Rate)
        {
            x = false;
        }
    }

    public void FillStars()
    {
        x = true;
    }
}
