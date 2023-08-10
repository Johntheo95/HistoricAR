using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;





public class QuestionAnswers : MonoBehaviour
{        public TextMeshProUGUI PageText;
        
         //public GameObject CanvasforConstitutions;
         public List<Button> ImageBTN = new List<Button>();
         //public List<Sprite> ImageBTN = new List<Sprite>();
         int  currentpage;
         int  Showpage;
         public Color SelectedRed;
         public Color SelectedGreen;
         
         
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async  void  PressedChoise(int clickedChoice)
    { 
        
     ///ColorBlock cb = ImageBTN[clickedChoice].colors;

       //if(currentpage == 0)
      // {Showpage = 1;}    
       
       
       //button.GetComponent<Button>().colorBlock.pressedColor  = new Color(1.0f, 0.0f, 0.0f, 1.0f);
  
       Showpage = PageText.pageToDisplay;
       Debug.Log("clicked"+clickedChoice);
       Debug.Log("page"+Showpage); 
        
            if (1+clickedChoice== Showpage){
           // cb.pressedColor = SelectedGreen;
           // ImageBTN[clickedChoice].colors=cb;  //on click changed the color in inspector
           ImageBTN[clickedChoice].GetComponent<Image>().color = Color.green;
            await Task.Delay(700);
            PageText.pageToDisplay++;
            Showpage = PageText.pageToDisplay;
            Debug.Log(PageText.pageToDisplay);

            
            ImageBTN[1].GetComponent<Image>().color = Color.white;
            ImageBTN[2].GetComponent<Image>().color = Color.white;
            ImageBTN[3].GetComponent<Image>().color = Color.white;
            }
            
            else {
            //cb.pressedColor = SelectedRed;
            //ImageBTN[clickedChoice].colors=cb;   
           ImageBTN[clickedChoice].GetComponent<Image>().color = Color.red;
            }

    
    
    
    }
    

}
