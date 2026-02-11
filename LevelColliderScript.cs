using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelColliderScript : MonoBehaviour
{
	public string nextLevel;
	public GameObject fader;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			StartCoroutine("LevelLoader");
		}
	}


	private IEnumerator LevelLoader()
    {
		fader.GetComponent<Animator>().SetBool("Fade", true);
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(nextLevel);
    }
}