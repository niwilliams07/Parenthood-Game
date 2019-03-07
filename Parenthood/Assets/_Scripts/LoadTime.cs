using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadTime : MonoBehaviour {

    public int seconds;
    public int index;
    public Image black;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(seconds);
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
