using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleModelsBasedOnPages : MonoBehaviour
{       
         [SerializeField]
         public TextMeshProUGUI PageText;
         public GameObject menuObject;
         public GameObject menuObject2;
         public GameObject menuObject3;
         public GameObject menuObject4;
         
        public int TargetPage;
        public int TargetPage2;
         //public TMP_Text Text2; also work
         public TextMeshProUGUI Text2;
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

    public void ShowNextModel()
{        
         totalpages = PageText.textInfo.pageCount; 
         bool currentState  =  menuObject.activeSelf;
         bool currentState2 = menuObject2.activeSelf;
         bool currentState3 = menuObject3.activeSelf;
         currentpage = PageText.pageToDisplay;
         // Text2 =GetComponent<TextMeshProUGUI>();
         
         if (currentpage == TargetPage)
         {
           //Debug.Log("currentpage"+ currentpage);
           //Debug.Log("menuObject"+ currentState);
           //Debug.Log("menuObject2"+currentState2);
            menuObject.SetActive(!currentState);
            menuObject2.SetActive(!currentState2);
            menuObject3.SetActive(!currentState3);
            Text2.enabled = true;  
        }
      
}


    public void ShowNextModelVer2()
{        
         totalpages = PageText.textInfo.pageCount; 
         bool currentState  =  menuObject.activeSelf;
         bool currentState2 = menuObject2.activeSelf;
         bool currentState3 = menuObject3.activeSelf;
         bool currentState4 = menuObject4.activeSelf;
         currentpage = PageText.pageToDisplay;
         // Text2 =GetComponent<TextMeshProUGUI>();
         
         if (currentpage == TargetPage)
         {
           //Debug.Log("currentpage"+ currentpage);
           //Debug.Log("menuObject"+ currentState);
           //Debug.Log("menuObject2"+currentState2);
            menuObject.SetActive(!currentState);
            menuObject2.SetActive(!currentState2);
        }

        if (currentpage == TargetPage2)
        {
            menuObject2.SetActive(!currentState2);
            menuObject3.SetActive(!currentState3);
            menuObject4.SetActive(!currentState4);

        }
}

        
        public void ShowNextModelVer3()
{        
         totalpages = PageText.textInfo.pageCount; 
         bool currentState  =  menuObject.activeSelf;
         bool currentState2 = menuObject2.activeSelf;
         bool currentState3 = menuObject3.activeSelf;
         bool currentState4 = menuObject4.activeSelf;
         currentpage = PageText.pageToDisplay;
         // Text2 =GetComponent<TextMeshProUGUI>();
         
         if (currentpage == TargetPage)
         {
           //Debug.Log("currentpage"+ currentpage);
           //Debug.Log("menuObject"+ currentState);
           //Debug.Log("menuObject2"+currentState2);
            menuObject.SetActive(!currentState);
            menuObject2.SetActive(!currentState2);
            menuObject3.SetActive(!currentState3);
        }

        if (currentpage == TargetPage2)
        {
            menuObject4.SetActive(!currentState4);

        }
}







}
