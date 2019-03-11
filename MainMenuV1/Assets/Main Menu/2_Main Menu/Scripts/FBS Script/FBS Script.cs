using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class FBSScript : MonoBehaviour
{
    public Animator anim;
    public Image image;

    public void SceneGameplay()
    {
        //SceneManager.LoadScene("SceneGameplay");
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => image.color.a == 1);
        SceneManager.LoadScene("Scene01");
    }
}
