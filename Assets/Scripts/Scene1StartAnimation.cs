using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class Scene1StartAnimation : MonoBehaviour
{
    //maybe set position to 0 and re-enable componenct?
    [SerializeField]
    //public GameObject _soldierNo1;
    SplineFollower _soldierNo1;
    
    // Start is called before the first frame update
     
    void Start()
    {
     
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