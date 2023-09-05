using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TEXTMESHPAGES : MonoBehaviour
{   
    
    [SerializeField]
    public TextMeshProUGUI PageText;
    //public TMP_Text PageText;
    int  currentpage = 1;
    int totalpages;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ButtonNextPage()
{      
         totalpages = PageText.textInfo.pageCount; 
         //PageText = GetComponent<TextMeshPro>();
        // Debug.Log(totalpages);
        // Debug.Log(PageText.pageToDisplay);  //This works
         currentpage= PageText.pageToDisplay;
         //Debug.Log(PageText.Page);
         //int currentpage = PageText.pageIndex;
        
         if (currentpage <= totalpages)
         {
         currentpage++;
         PageText.pageToDisplay++;
         //currentpage.pageCount++;
         
        }
}

    public void ButtonPreviousPage()
{      
         totalpages = PageText.textInfo.pageCount; 
         //PageText = GetComponent<TextMeshPro>();
         Debug.Log(totalpages);
        // Debug.Log(PageText.pageToDisplay);  //This works
         currentpage= PageText.pageToDisplay;
         //Debug.Log(PageText.Page);
         //int currentpage = PageText.pageIndex;
        
         if ((currentpage >= totalpages) || (currentpage >= 1))
         {
         currentpage--;
         PageText.pageToDisplay--;
         //currentpage.pageCount++;
         
        }
}



}
