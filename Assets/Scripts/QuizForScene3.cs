using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;
using Dreamteck.Splines;

public class QuizForScene3 : MonoBehaviour
{
    int i,j=0;
    int  currentpage;
    int  Showpage;
    public List<Button> ImageBTN = new List<Button>();
    public List<TMP_Text> ShowAnswersTXT = new List<TMP_Text>();
    public TextMeshProUGUI QuestionPageTXT,CorrectNumAnswersTXT,CorrectNumAnswers2TXT;
    public SplineFollower[] thePaths;
    public SplineFollower[] thePaths1;
    public GameObject Soldier,SoldierAnimed,QuestionPanel,CanvasUI;
    int questiontxt,row,column,correctanwser,questionrow,row2,column2,correctanwser2,questionrow2;
    public bool IsActive = true;
    
    private string[] Questions = {
        "Ποιος ήταν ο δάσκαλος του Μ.Αλεξάνδρου;",
        "Ποιον ηρώα που θαύμαζε ο Μ.Αλέξανδρος τίμησε στην Τροία;",
        "Που έγινε η πρώτη μάχη της εκστρατείας κατά των Περσών.",
        "Οι κάτοικοι των πόλεων της Μ.Ασίας αντιμετώπισαν τον Αλέξανδρο ως:",
        "Η/Το  ___ της Αιγύπτου που αναδείχτηκε σε  σπουδαία πόλη ιδρύθηκε από τον Αλέξανδρο.."
    };

        private string[] Questions2 = {
        "Σε αυτή την μάχη οι Πέρσες κατατροπώθηκαν ολοκληρωτικά .",
        "Ποτέ έγινε η προαναφερθείσα μάχη;",
        "Όταν έφτασαν στον Ινδό ποταμό οι στρατιώτες  αποφάσισαν να ___;",
        "Έπειτα από πολύ σκέψη ο Αλέξανδρος αποφάσισε  να",
        "Μετά από πολλές δυσκολίες ο στρατός κατέφερε  να φτάστει στην",
        "Το 323π.Χ ο Αλέξανδρος πέθανε."
    };

        private string[,] AnswersOption = {
        {"Αριστοτέλης ","Φίλιππος"},
        {"Αχιλλέα","Οδυσσέα"},
        {"Ισσό","Γρανικό "},
        {"Ελευθερωτή ","Κατακτητή "},
        {"Κάιρο","Αλεξάνδρεια"}   
    };

            private string[,] AnswersOption2 = {
        {"Σούσα","Γαυγάμηλα "},
        {"331 π.Χ","333 π.Χ"},
        {"Συνεχίσουν","Διαμαρτυρηθούν"},
        {"Επιστρέψει","Προχωρήσει"},
        {"Κίνα","Βαβυλώνα"},
        {"Σωστό","Λάθος"}   
    };
        private int[] Answer = {
        0,0,1,0,1   
    };
        private int[] Answer2 = {
        1,0,1,0,1,0  
    };

    // Start is called before the first frame update
    void Start()
    {  
         ShowTexts();
        thePaths = Soldier.GetComponents<SplineFollower>();
        thePaths1 = SoldierAnimed.GetComponents<SplineFollower>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalledOnClick(int clickedChoice)
    {
        if(IsActive)
        {
                PressedChoisePath1(clickedChoice);
                Debug.Log("PressedChoisePath1");
                Debug.Log("IsActive"+IsActive);

        }
        else
        {
                PressedChoisePath2(clickedChoice);
                Debug.Log("PressedChoisePath2");
        }
    }

    public void PausePath1(){
      
      thePaths[0].enabled = false;
      thePaths1[0].enabled = false;
    }

    public void PausePath2(){
      
      thePaths[1].enabled = false;
      thePaths1[1].enabled = false;
    }

    public async void  PressedChoisePath1(int clickedChoice){

        if(clickedChoice==Answer[i]){
        correctanwser++;
        i++;
        ImageBTN[clickedChoice].GetComponent<Image>().color = Color.green;
        await Task.Delay(1000);
        }
        else{
        ImageBTN[clickedChoice].GetComponent<Image>().color = Color.red;
        i++;
        await Task.Delay(1000);
        }
        
        j++; 
        ImageBTN[0].GetComponent<Image>().color = Color.white;
        ImageBTN[1].GetComponent<Image>().color = Color.white;
        
        Debug.Log("Pressed1I="+i);
        Debug.Log("Pressed1Jis="+j);
        Debug.Log("correctAnwserfor1Pressed"+correctanwser);
        
        
        if(j == 5){
        CorrectNumAnswersTXT.text = "Οι σωστές απαντήσεις απο το Πρώτο Quiz του κεφαλαίου ήταν: "+ correctanwser + 
                                    "\nΚαι οι λανθασμένες : " + (Answer.Length-correctanwser);
        SoldierAnimed.GetComponent<Animator>().enabled = true;
        thePaths[0].enabled = true;
        thePaths1[0].enabled = true;
        QuestionPanel.SetActive(false);
        CanvasUI.SetActive(true);
        i=0;
        j=0;
        ShowTexts2();
        IsActive = false;
        return;
        }
        ShowTexts();
     }

        public async void  PressedChoisePath2(int clickedChoice){

        if(clickedChoice==Answer2[i]){
        correctanwser2++;
        i++;
        ImageBTN[clickedChoice].GetComponent<Image>().color = Color.green;
        await Task.Delay(1000);
        }
        else{
        ImageBTN[clickedChoice].GetComponent<Image>().color = Color.red;
        i++;
        await Task.Delay(1000);
        }
        
        j++; 
        ImageBTN[0].GetComponent<Image>().color = Color.white;
        ImageBTN[1].GetComponent<Image>().color = Color.white;
        
        Debug.Log("Pressed2Jis=="+j);
        //Debug.Log("correctanwser"+correctanwser);
         
        if(j == 6){
        CorrectNumAnswers2TXT.text = "Οι σωστές απαντήσεις απο το Δεύτερο Quiz του κεφαλαίου ήταν: "+ correctanwser2 + 
                                    "\nΚαι οι λανθασμένες : " + (Answer2.Length-correctanwser2);
        SoldierAnimed.GetComponent<Animator>().enabled = true;
        thePaths[1].enabled = true;
        thePaths1[1].enabled = true;
        QuestionPanel.SetActive(false);
        CanvasUI.SetActive(true);
        return;
        }
        ShowTexts2();
     }


    private void ShowTexts(){

    if (row< AnswersOption.GetLength(0)) {           
            ShowAnswersTXT.ForEach(TMPInButton => TMPInButton.text = AnswersOption[row, column++]);
            column = 0; row++;
            
            }
    QuestionPageTXT.text=Questions[questionrow++]; 
    }

    private void ShowTexts2(){

    if (row2< AnswersOption2.GetLength(0)) {           
            ShowAnswersTXT.ForEach(TMPInButton => TMPInButton.text = AnswersOption2[row2, column2++]);
            column2 = 0; row2++;
            
            }
    QuestionPageTXT.text=Questions2[questionrow2++]; 
    }
}
