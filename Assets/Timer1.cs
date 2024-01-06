using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour
{
    public float timestart;

    public Text TextBox;
   
    // Start is called before the first frame update
    void Start()
    {  
        TextBox.text = timestart.ToString("F3");
      
    } 

    // Update is called once per frame
    void Update()
    {
       timestart += Time.deltaTime;
       TextBox.text = timestart.ToString("F2"); 
    } 
}
 