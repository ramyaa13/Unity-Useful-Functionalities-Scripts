using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SplashScreen());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
