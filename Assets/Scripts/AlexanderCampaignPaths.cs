using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class AlexanderCampaignPaths : MonoBehaviour
{       [SerializeField]
        //public GameObject SplineFollower;
        public GameObject objectToCheck;
        SplineFollower[] thePaths;
        
    // Start is called before the first frame update
    void Start()
    {   
        //SplineFollowers[] SplineFollowers;
        
        
        //SplineFollowers = SplineFollower.GetComponent<SplineFollower>();
         

        thePaths = objectToCheck.GetComponents<SplineFollower>();

         

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCampaign()
    {
        thePaths[0].enabled = true;
        
    }
    public void NextCampaign()
    {
       thePaths[1].enabled = true;
    }

}
