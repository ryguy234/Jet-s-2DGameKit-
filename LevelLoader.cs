using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public GameObject fader;

    public void LoadLevel()
    {
        StartCoroutine("NextLevel");
    }


    IEnumerator NextLevel()
    {
        fader.GetComponent<Animator>().SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
