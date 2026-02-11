using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayNow : MonoBehaviour
{
    public GameObject fader;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            StartCoroutine("LevelLoader");
        }
    }

    private IEnumerator LevelLoader()
    {
        fader.GetComponent<Animator>().SetBool("Fade", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
