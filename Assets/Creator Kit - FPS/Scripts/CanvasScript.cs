using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanvasScript : MonoBehaviour

{
    public Text myText;
    public GameObject myCanvas;
    
    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider self)
    {
        //if (self.name == collider1.name)
        //{
        //    Debug.Log("asdaaaaaaasd");
        //}
        if (this.name=="collider")
        {
            myText.text = "annen";
        }
        if (this.name == "collider2")
        {
            myText.text = "baban";
        }
        myCanvas.SetActive(true);
            
    }
    
    
    void OnTriggerExit()
    {
        myCanvas.SetActive(false);
    }
    

    
           
      
        
        


}