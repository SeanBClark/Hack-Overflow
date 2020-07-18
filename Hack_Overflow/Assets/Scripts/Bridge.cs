using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public bool isEnabled;
    public bool BridgeOpening;
    public bool BridgeClosing;
    public bool isReady;
    public SpriteRenderer render;
    public float movementSpeed;
    public float xLocA, xLocB;
    // Start is called before the first frame update
    void Start()
    {
        isEnabled = false;
        BridgeOpening = false;
        BridgeClosing = false;
        isReady = true;
    }

    private void Update()
    {
        if (BridgeOpening)
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
            if (transform.position.x >= xLocB)
            {
                isReady = true;
                BridgeOpening = false;
            }
        }
        if (BridgeClosing)
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);

            if (transform.position.x <= xLocA)
            {
                isReady = true;
                BridgeClosing = false;
            }
        }
    }

    public void Switch()
    {
        isEnabled = !isEnabled;
        if (isEnabled)
        {
            OpenBridge();
        }
        else
        {
            CloseBridge();
        }
    }

    public void OpenBridge()
    {
        isReady = false;
        BridgeOpening = true;
        Debug.Log("Opening Bridge");
    }

    public void CloseBridge()
    {
        isReady = false;
        BridgeClosing = true;
        Debug.Log("Closing Bridge");
    }

    void Awake()
    {
        render = GetComponent<SpriteRenderer>();
    }
}
