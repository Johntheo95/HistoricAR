using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleONOFF : MonoBehaviour
{
    [SerializeField]
    public GameObject menuObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    { 
       if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){//    Input.GetMouseButtonDown(0)
          Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);//     Input.mousePosition
          RaycastHit hit;  
            if( Physics.Raycast(ray, out hit) && hit.collider.gameObject== gameObject ){ 
                ToggleActiveState();
              //  if (hit.transform == transform){ // this also works
              //    if (hit.collider.tag == "Object1"){ No need for  tag
              //  }   }  
             } 
        }
    }
         
    public void ToggleActiveState()
    {

        bool currentState = menuObject.activeSelf;
       // Debug.Log(currentState);
        menuObject.SetActive(!currentState);
    }

}
