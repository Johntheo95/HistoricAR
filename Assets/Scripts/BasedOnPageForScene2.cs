using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BasedOnPageForScene2 : MonoBehaviour
{
             [SerializeField]
         public TextMeshProUGUI PageText;
         public GameObject menuObject;
         public GameObject menuObject2;
         public GameObject menuObject3;
         public GameObject menuObject4;
         public GameObject menuObject5;
         public GameObject menuObject6;
         public GameObject menuObject7;
         public GameObject menuObject8;
         public GameObject menuObject9;
        public int TargetPage;
        public int TargetPage2;
        public int TargetPage3;
        public int TargetPage4;
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



        public void ShowHideModel()
{        
         totalpages = PageText.textInfo.pageCount; 
         bool currentState  =  menuObject.activeSelf;
         bool currentState2 = menuObject2.activeSelf;
         bool currentState3 = menuObject3.activeSelf;
         bool currentState4 = menuObject4.activeSelf;
         bool currentState5 = menuObject5.activeSelf;
         bool currentState6 = menuObject6.activeSelf;
         bool currentState7 = menuObject7.activeSelf;
         bool currentState8 = menuObject8.activeSelf;
         bool currentState9 = menuObject9.activeSelf;
         currentpage = PageText.pageToDisplay;

         if (currentpage == TargetPage)
         {
            menuObject.SetActive(!currentState);
        }
        else if (currentpage == TargetPage2){
             menuObject.SetActive(!currentState);
             menuObject2.SetActive(!currentState2);
             menuObject9.SetActive(!currentState9);
             }


         if (currentpage == TargetPage3) {
          menuObject3.SetActive(!currentState3);
          menuObject4.SetActive(!currentState4);
          }
        else if (currentpage == TargetPage4){
             menuObject3.SetActive(!currentState3);
             menuObject4.SetActive(!currentState4);
             menuObject5.SetActive(!currentState5);
             menuObject6.SetActive(!currentState6);
             }
         if(currentpage == TargetPage4+1) {
             menuObject5.SetActive(!currentState5);
             menuObject6.SetActive(!currentState6);
             menuObject7.SetActive(!currentState7);
             menuObject8.SetActive(!currentState8);
         }    
}
}
