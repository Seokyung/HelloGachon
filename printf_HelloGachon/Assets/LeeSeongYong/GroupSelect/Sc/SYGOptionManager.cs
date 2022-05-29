using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SYGOptionManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Option;
    public GameObject savepanel;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            OpenOption();
        }
    }
    public void OpenOption()
    {
        Option.SetActive(true);
    }
    public void CloseOption()
    {
        Option.SetActive(false);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void ExitPanel()
    {
        savepanel.SetActive(false);
    }
}
