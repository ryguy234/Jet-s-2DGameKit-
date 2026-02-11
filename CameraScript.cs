using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject mainCharacter;

    void Update()
    {

        this.gameObject.transform.position = new Vector3(mainCharacter.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

    }

}