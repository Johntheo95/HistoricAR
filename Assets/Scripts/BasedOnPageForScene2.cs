using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class BasedOnPageForScene2 : MonoBehaviour
{
        [SerializeField]
         public TextMeshProUGUI PageText;
         public GameObject menuObjectMap;
         public GameObject menuObject;
         public GameObject menuObject2;
         public GameObject menuObject3;
         public GameObject menuObject4;
         public GameObject menuObject5;
         public GameObject menuObject6;
         public GameObject menuObject7;
         public GameObject menuObject8;
         public GameObject menuObject9;
         public GameObject NextPageBTN;
         public GameObject PrevPageBTN;
        public int TargetPage;
        public int TargetPage2;
        public int TargetPage3;
        public int TargetPage4;
        public int TargetPage5;
        public int TargetPage6;
        int  currentpage;
        int totalpages;
        public GameObject PromptAskQuesion;
        public GameObject OptionDoric,OptionIonic,OptionRed,OptionBlack,Result;

        //public GameObject OptionB;
        //public ToggleONOFF Togglescript; use script instead?

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        ShowTheAnswer();
    }



        public void ShowHideModel()
        {        
            totalpages = PageText.textInfo.pageCount; 
            bool currentStateMap  =  menuObjectMap.activeSelf;
            bool currentState  =  menuObject.activeSelf;
            bool currentState2 = menuObject2.activeSelf;
            bool currentState3 = menuObject3.activeSelf;
            bool currentState4 = menuObject4.activeSelf;
            bool currentState5 = menuObject5.activeSelf;
            bool currentState6 = menuObject6.activeSelf;
            bool currentState7 = menuObject7.activeSelf;
            bool currentState8 = menuObject8.activeSelf;
            bool currentState9 = menuObject9.activeSelf;
            bool currentStateTXT = PromptAskQuesion.activeSelf;
            bool currentStateNBTN = NextPageBTN.activeSelf;
            bool currentStatePBTN = PrevPageBTN.activeSelf;
            

            currentpage = PageText.pageToDisplay;

            if (currentpage == TargetPage)
            {
                menuObjectMap.SetActive(!currentStateMap);
                menuObject.SetActive(!currentState);
            }
            else if (currentpage == TargetPage2){
                menuObject.SetActive(!currentState);
                menuObject2.SetActive(!currentState2);
                menuObject9.SetActive(!currentState9);
                }


            if (currentpage == TargetPage3) {
            //NextPageBTN.SetActive(false);
            //PrevPageBTN.SetActive(false);
            NextPageBTN.GetComponent<Image>().enabled= false;
            PrevPageBTN.GetComponent<Image>().enabled= false;     
            menuObject3.SetActive(!currentState3);
            menuObject4.SetActive(!currentState4);
            PromptAskQuesion.SetActive(!currentStateTXT);
            PromptAskQuesion.GetComponent<TMP_Text>().text= "ΠΟΙΟΣ ΚΙΟΝΑΣ ΕΙΝΑΙ ΙΟΝΙΚΟΥ ΡΥΘΜΟΥ;";
        
            }
            else if (currentpage == TargetPage4){
                Result.SetActive(false);
                PromptAskQuesion.SetActive(!currentStateTXT);
                menuObject3.SetActive(!currentState3);
                menuObject4.SetActive(!currentState4);
                menuObject5.SetActive(!currentState5);
                menuObject6.SetActive(!currentState6);
                
                
                }
            if(currentpage == TargetPage5) {
                //NextPageBTN.SetActive(false);
                //PrevPageBTN.SetActive(false);
                NextPageBTN.GetComponent<Image>().enabled= false;
                PrevPageBTN.GetComponent<Image>().enabled= false;
                PromptAskQuesion.SetActive(!currentStateTXT);
                PromptAskQuesion.GetComponent<TMP_Text>().text= "ΠΟΙΟ ΑΓΓΕΙΟ ΕΙΝΑΙ  ΤΟ ΕΡΥΘΡΟΜΟΡΦΟ;";
                menuObject5.SetActive(!currentState5);
                menuObject6.SetActive(!currentState6);
                menuObject7.SetActive(!currentState7);
                menuObject8.SetActive(!currentState8);

            }    
            if(currentpage == TargetPage6) {
                Result.SetActive(false);
                PromptAskQuesion.SetActive(false);
                menuObject7.SetActive(false);
                menuObject8.SetActive(false);
                menuObject5.SetActive(false);
                menuObject6.SetActive(false);
                NextPageBTN.SetActive(false);
                PrevPageBTN.SetActive(false);
        
            }  
         
        }


    public void ShowHidePrevModel()
        {        
            totalpages = PageText.textInfo.pageCount; 
            bool currentStateMap  =  menuObjectMap.activeSelf;
            bool currentState  =  menuObject.activeSelf;
            bool currentState2 = menuObject2.activeSelf;
            bool currentState3 = menuObject3.activeSelf;
            bool currentState4 = menuObject4.activeSelf;
            bool currentState5 = menuObject5.activeSelf;
            bool currentState6 = menuObject6.activeSelf;
            bool currentState7 = menuObject7.activeSelf;
            bool currentState8 = menuObject8.activeSelf;
            bool currentState9 = menuObject9.activeSelf;
            bool currentStateTXT = PromptAskQuesion.activeSelf;
            

            currentpage = PageText.pageToDisplay;

            if (currentpage == TargetPage)
            {
                menuObjectMap.SetActive(!currentStateMap);
                menuObject.SetActive(!currentState);
            }
            else if (currentpage == TargetPage2){
                menuObject.SetActive(!currentState);
                menuObject2.SetActive(!currentState2);
                menuObject9.SetActive(!currentState9);
                }


            if (currentpage == TargetPage3) {
            Result.SetActive(false);
            menuObject3.SetActive(!currentState3);
            menuObject4.SetActive(!currentState4);
            PromptAskQuesion.SetActive(!currentStateTXT);
            NextPageBTN.SetActive(true);
            PrevPageBTN.SetActive(true);
            
            
            }
            else if (currentpage == TargetPage4){
                Result.SetActive(true);
                PromptAskQuesion.SetActive(!currentStateTXT);
                PromptAskQuesion.GetComponent<TMP_Text>().text= "ΠΟΙΟΣ ΚΙΟΝΑΣ ΕΙΝΑΙ ΙΟΝΙΚΟΥ ΡΥΘΜΟΥ;";
                menuObject3.SetActive(!currentState3);
                menuObject4.SetActive(!currentState4);
                menuObject5.SetActive(!currentState5);
                menuObject6.SetActive(!currentState6);
                NextPageBTN.SetActive(true);
                PrevPageBTN.SetActive(true);
                }
            if(currentpage == TargetPage5) {
                Result.SetActive(false);
                PromptAskQuesion.SetActive(!currentStateTXT);
                menuObject5.SetActive(!currentState5);
                menuObject6.SetActive(!currentState6);
                menuObject7.SetActive(!currentState7);
                menuObject8.SetActive(!currentState8);
                NextPageBTN.SetActive(true);
                PrevPageBTN.SetActive(true);
            }             
        }    
    
    
    
    public void ShowTheAnswer(){
      
       currentpage = PageText.pageToDisplay;
       Debug.Log("Showmodel"+ currentpage);
        if(currentpage == TargetPage3){
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){//    Input.GetMouseButtonDown(0)
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);//     Input.mousePosition
                RaycastHit hit;  
                if( Physics.Raycast(ray, out hit) && (hit.collider.gameObject.CompareTag("Ionikos"))){ 
                    OptionIonic.SetActive(true);
                    OptionDoric.SetActive(true);
                    Result.SetActive(true);
                    Result.GetComponent<TMP_Text>().text= "ΣΩΣΤΟ";
                    Result.GetComponent<TMP_Text>().color = Color.green;
                    //NextPageBTN.SetActive(true);
                   //PrevPageBTN.SetActive(true);
                    NextPageBTN.GetComponent<Image>().enabled= false;
                    PrevPageBTN.GetComponent<Image>().enabled= false;

                }
                else if( Physics.Raycast(ray, out hit) && (hit.collider.gameObject.CompareTag("Dorikos"))){
                    OptionDoric.SetActive(true);
                    OptionIonic.SetActive(true);
                    Result.SetActive(true);
                    Result.GetComponent<TMP_Text>().text= "ΛΑΘΟΣ";
                    Result.GetComponent<TMP_Text>().color = Color.red;
                    //NextPageBTN.SetActive(true);
                    //PrevPageBTN.SetActive(true);
                    NextPageBTN.GetComponent<Image>().enabled= true;
                    PrevPageBTN.GetComponent<Image>().enabled= true;
                }

            }
        } 
        
        if(currentpage == TargetPage5){
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){//    Input.GetMouseButtonDown(0)
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);//     Input.mousePosition
                RaycastHit hit;  
                if( Physics.Raycast(ray, out hit) && (hit.collider.gameObject.CompareTag("Melanomorfos"))){ 
                        OptionRed.SetActive(true);
                        OptionBlack.SetActive(true);
                        Result.SetActive(true);
                        Result.GetComponent<TMP_Text>().text= "ΛΑΘΟΣ";
                        Result.GetComponent<TMP_Text>().color = Color.red;
                        //NextPageBTN.SetActive(true);
                        //PrevPageBTN.SetActive(true);
                        NextPageBTN.GetComponent<Image>().enabled= true;
                        PrevPageBTN.GetComponent<Image>().enabled= true;
                }

                if( Physics.Raycast(ray, out hit) && (hit.collider.gameObject.CompareTag("Eruthromorfo"))){
                        OptionBlack.SetActive(true);
                        OptionRed.SetActive(true);
                        Result.SetActive(true);
                        Result.GetComponent<TMP_Text>().text= "ΣΩΣΤΟ";
                        Result.GetComponent<TMP_Text>().color = Color.green;
                        //NextPageBTN.SetActive(true);
                        //PrevPageBTN.SetActive(true);  
                        NextPageBTN.GetComponent<Image>().enabled= true;
                        PrevPageBTN.GetComponent<Image>().enabled= true;  
                }  
            } 
        }   
    }
}
