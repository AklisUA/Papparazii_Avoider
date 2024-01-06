using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DroneFunctions : MonoBehaviour
{   public Player player;
    private GameObject playerObj;
    public GameObject Info;
    private float timestart;
    private Renderer m_Renderer;
    private bool m_isphoted = false;
    void Start()
    {
        Info = Info = GameObject.Find("Canvas").transform.GetChild(3).gameObject;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
        m_Renderer = GetComponent<Renderer>();
        gameObject.transform.Rotate(new Vector3(0, 180, 0));
    }

    // Update is called once per frame
    void Update()
    {
        timestart += Time.deltaTime;
        if (timestart >2.0 ) 
        {
            if (m_Renderer.isVisible && m_isphoted == false )
            {  
                m_isphoted= true;
                Info.SetActive(true);
                Debug.Log("TakePhoto");
                player.Hplost();
            }
                           
        }   
        if (timestart > 3.0 )
        {
            Info.SetActive(false);
            Destroy(gameObject);
        }
    }
}
