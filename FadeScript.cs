using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{

    public Animator animator;
    public string nextLevel;

    void Update()
    {

    }

    public void LoadLevel()
    {
        StartCoroutine("Fade");
    }



    IEnumerator Fade()
    {
        animator.SetTrigger("Fade");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextLevel);

    }
}
