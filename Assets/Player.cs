using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour

{
    public GameObject HP;
    [HideInInspector]
    public int health;

    // Start is called before the first frame update
    void Start()
    {
       // GameOverWindow.SetActive(false);
        health = 3;
        HP.GetComponent<Text>().text= health.ToString();  
    }  
    
    
    // Update is called once per frame
    public void Hplost()
    {
        health--;
        HP.GetComponent<Text>().text = health.ToString();
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


        }
       
    }

    
}
