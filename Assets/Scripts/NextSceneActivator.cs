using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NextSceneActivator : MonoBehaviour
{
     [SerializeField]
     public TextMeshProUGUI PageText;
     public GameObject menuObject;


    int  currentpage;
    int totalpages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ShowPanelForNextScene()
{      
         totalpages = PageText.textInfo.pageCount; 
         
        // Debug.Log(totalpages);
        // Debug.Log(PageText.pageToDisplay);  //This works
         currentpage= PageText.pageToDisplay;
         if (currentpage == totalpages)
         {
            bool currentState = menuObject.activeSelf;
           // Debug.Log(currentState);
                //     Debug.Log(totalpages);
       //  Debug.Log(PageText.pageToDisplay);  //This works
            menuObject.SetActive(!currentState);
        }
}
}
