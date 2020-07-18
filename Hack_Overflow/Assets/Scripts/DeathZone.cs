using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject DeathMenuObj;

    private void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log(collider.gameObject.tag + " triggered DeathZone");
        if (collider.gameObject.tag == "Player")
        {
            Destroy(collider.gameObject);
            DeathMenuObj.SetActive(true);
        }
    }
}
