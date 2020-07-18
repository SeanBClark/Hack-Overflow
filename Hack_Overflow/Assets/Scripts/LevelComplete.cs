using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject VictoryMenuObj;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.tag + "triggered LevelComplete");
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.SetActive(false);
            VictoryMenuObj.SetActive(true);

        }
    }
}
