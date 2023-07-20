using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{   [SerializeField]
    public GameObject AnimationObject;


    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndTheAnimation()
    {
        AnimationObject.GetComponent<Animator>().enabled = false;
    }
}
