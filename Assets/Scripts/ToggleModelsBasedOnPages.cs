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
         public int TargetPage;

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
         bool currentState = menuObject.activeSelf;
         bool currentState2 = menuObject2.activeSelf;
         currentpage= PageText.pageToDisplay;
         menuObject2.SetActive(!currentState);
         if (currentpage == TargetPage)
         {
           //Debug.Log("currentpage"+ currentpage);
            //Debug.Log("menuObject"+ currentState);
           //Debug.Log("menuObject2"+currentState2);
            menuObject.SetActive(!currentState);
            menuObject2.SetActive(!currentState2);
         
        }
}

}
