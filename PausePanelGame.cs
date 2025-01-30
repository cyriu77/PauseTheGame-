using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanelGame : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isPauPanPased = false;
    public GameObject pauseShPanel;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauPanPased)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
       
    }
    public void Pause()
    {
        pauseShPanel.SetActive(true);
        Time.timeScale = 0f;

        isPauPanPased = true;
    }
    public void Resume()
    {

        pauseShPanel.SetActive(false);
        Time.timeScale = 1f;
        isPauPanPased = false;
    }
}
