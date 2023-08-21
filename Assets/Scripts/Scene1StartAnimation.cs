using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class Scene1StartAnimation : MonoBehaviour
{
    [SerializeField]
    SplineFollower _soldierNo1;
    
    // Start is called before the first frame update
    void Start()
    {
     _soldierNo1.enabled = false;
    }
// Update is called once per frame
    void Update()
    {
        
    }
    public void StartTheAnimation()
    {
        _soldierNo1.enabled = true;
    }
     
}