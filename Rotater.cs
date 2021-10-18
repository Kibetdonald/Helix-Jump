using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{   
    public float rotationSpeed =150 ;
    
    

    // Update is called once per frame
    void Update()
    {  if(!GameManager.isGameStarted)
    return  ;
        
        
    if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
         float xDelta =Input.GetTouch(0).deltaPosition.x;
         transform.Rotate(0,-xDelta *rotationSpeed *Time.deltaTime,0);
     }
    }
}
