using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void Restart()
    {
        Debug.Log("2424");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }

    public void MenuExit()
    {             
        Debug.Log("ÂÛÔÂÛÂ");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);

    }
}
