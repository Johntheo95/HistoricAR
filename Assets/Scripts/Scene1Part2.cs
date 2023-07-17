using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class Scene1Part2 : MonoBehaviour
{   [SerializeField]
    SplineFollower _boatGreen;
    [SerializeField]
    SplineFollower _boatOrange;
    [SerializeField]
    SplineFollower _boatBlue;
    
            // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void SecondAnimation()
    {
        _boatGreen.enabled = true;
        _boatOrange.enabled = true;
        _boatBlue.enabled = true;
    }
}
