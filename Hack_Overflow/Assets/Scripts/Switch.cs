using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isEnabled;
    public GameObject switchableObj;
    // Start is called before the first frame update
    void Start()
    {
        isEnabled = true;

    }

    private void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (isEnabled)
        {
            if (col.gameObject.tag == "Player" && Input.GetButton("Use"))
            {
                if(switchableObj.GetComponent<Bridge>().isReady == true)
                {
                    switchableObj.GetComponent<Bridge>().Switch();
                    StartCoroutine(DisableSwitch(2));
                }
            }
        }
    }

    public IEnumerator DisableSwitch(float duration)
    {
        isEnabled = false;
        Debug.Log("Disabled switch");
        yield return new WaitForSeconds(duration);
        isEnabled = true;
        Debug.Log("Enabled switch");
    }
}
