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
        
    }

    public void ToggleActiveState()
    {

        bool currentState = menuObject.activeSelf;
        Debug.Log(currentState);
        menuObject.SetActive(!currentState);
    }
}
