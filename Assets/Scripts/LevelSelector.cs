using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class LevelSelector : MonoBehaviour
{
    //public Button[] levelButtons;

    public void Select()
    {
        string levelName = EventSystem.current.currentSelectedGameObject.name;
        switch (levelName)
        {
            case "Button1":
                SceneManager.LoadScene(2);
                break;
            case "Button2":
                SceneManager.LoadScene(3);
                break;
            case "Button3":
                SceneManager.LoadScene(4);
                break;
            case "Next":
                int index = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(index + 1);
                Time.timeScale = 1f;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
