using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TEST : MonoBehaviour
{   
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if( Physics.Raycast(ray, out hit)){
                if (hit.transform == transform){
            Debug.Log("I WORK");}
            }
        }
    }
        //     }
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;
        // if (Input.GetMouseButtonDown(0))
        // {
        //     if(Physics.Raycast(ray,out hit) && hit.collider.gameObject== gameObject)
        //     {unityEvent.Invoke();}
        // }
    
}
