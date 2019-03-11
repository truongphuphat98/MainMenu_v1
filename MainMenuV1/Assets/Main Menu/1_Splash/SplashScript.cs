using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SplashScript : MonoBehaviour
{
    public Image splashimg;
    public GameObject Scrollsky;
    public string loadLevel;

    IEnumerator Start()
    {
        splashimg.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadLevel);

    }

    void FadeIn()
    {
        splashimg.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashimg.CrossFadeAlpha(0.0f, 2.5f, false);
    }

}
