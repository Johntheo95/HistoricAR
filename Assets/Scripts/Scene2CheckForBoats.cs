using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scene2CheckForBoats : MonoBehaviour
{
    public TextMeshProUGUI PageText;
    public GameObject PromptMessage;
    public GameObject BoatFrance;
    public GameObject BoatNorth;
    public GameObject BoatItaly;
    public GameObject NextPageBTN;
    public int TargetPage;
    public int TargetPage2;
    int  currentpage;
    int totalpages;
    int a,b,c;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {   
        if (BoatFrance.activeSelf == true){
            a=1;
         }

        if (BoatNorth.activeSelf == true){
            b=1;  
        }
        if (BoatItaly.activeSelf == true){
            c=1;
         }


        if(PromptMessage.activeSelf == true){
            PromptMessage.GetComponent<TMP_Text>().text = "Πατήστε πάνω στις τοποθεσίες των χωρών(έντονα γράμματα) για να δείτε την μετακίνηση."+ "\n" +(a+b+c)+"/3";
        }
         
        if (BoatFrance.activeSelf == true && BoatNorth.activeSelf == true && BoatItaly.activeSelf == true && PageText.pageToDisplay==3 )
        {
            NextPageBTN.SetActive(true);
            
        }
        if(PageText.pageToDisplay == 4) {
            PromptMessage.SetActive(false);
        }
        
    }
    public void ShowNextPageOnShipsDone(){
        totalpages = PageText.textInfo.pageCount; 
        currentpage = PageText.pageToDisplay;
        if (currentpage == TargetPage  & BoatFrance.activeSelf == false & BoatNorth.activeSelf == false & BoatItaly.activeSelf == false ){
            NextPageBTN.SetActive(false);
            PromptMessage.SetActive(true);
        }
              
    }   
    
     public void ShowNextPageBTNonPreviousClick(){
            currentpage = PageText.pageToDisplay;
            if (currentpage == TargetPage2 && NextPageBTN.activeSelf==false){
            NextPageBTN.SetActive(true);
            }
        }

}
    
    

