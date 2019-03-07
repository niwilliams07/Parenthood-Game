using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour
{
    public int index;
    public Image black;
    public Animator anim;

    public void LoadByIndex(int sceneINdex)
    {
        StartCoroutine(Fading());

    }
    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
