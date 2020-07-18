using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitMenu : MonoBehaviour
{
    public Button btnStart;
    public Button btnExit;
    public Canvas menuExit;
    // Start is called before the first frame update
    void Start()
    {
        btnStart = btnStart.GetComponent<Button>();
        btnExit = btnExit.GetComponent<Button>();
        menuExit = menuExit.GetComponent<Canvas>();
        menuExit.enabled = false;
    }

    public void ShowExitMenu()
    {
        btnStart.enabled = false;
        btnExit.enabled = false;
        menuExit.enabled = true;
    }

    public void HideExitMenu()
    {
        btnStart.enabled = true;
        btnExit.enabled = true;
        menuExit.enabled = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
