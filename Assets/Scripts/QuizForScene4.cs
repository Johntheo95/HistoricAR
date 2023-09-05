using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;
using Dreamteck.Splines;

public class QuizForScene4 : MonoBehaviour
{   
    int i,j=0;
    int  currentpage;
    int  Showpage;
    public List<Button> ImageBTN = new List<Button>();
    public List<TMP_Text> ShowAnswersTXT = new List<TMP_Text>();
    public TextMeshProUGUI QuestionPageTXT,CorrectNumAnswersTXT;
    public SplineFollower SoldierPath;
    public GameObject Soldier,QuestionPanel,CanvasUI;
    int questiontxt,row,column,correctanwser,questionrow;

   
    private string[] Questions = {
        "Με τον ορό «πύρρεια νίκη» αναφερόμαστε σε νίκη με",
        "Γιατί ο Πύρρος  δεν πολιόρκησε την Ρωμη",
        "Ο Πυρρός  κατάφερε να νικήσει σε όλες  τις μάχες στην Ιταλία.",
        "Η εκστρατεία του Πυρρού προς την Σπαρτή στέφτηκε με επιτυχία.",
        "Η τελευταία μάχη του Πυρρού ήταν στο Άργος όπου και σκοτώθηκε."
    };
    
    private string[,] AnswersOption = {
        {"Πολλές απώλειες","Μεγάλη ευκολία"},
        {"Μεγάλη απόσταση","Ελλιπείς δυνάμεις"},
        {"Σωστό1","Λάθος1"},
        {"Σωστό2","Λάθος2"},
        {"Σωστό3","Λάθος3"}
        
    };
    private int[] Answer = {
        0,1,1,1,0   
    };

    // Start is called before the first frame update
    void Start()
    {
    ShowTexts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PausePath(){

        SoldierPath.enabled = false;

    }

     public async void  PressedChoisePurros(int clickedChoice){

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
        
        Debug.Log("j"+j);
        Debug.Log("correctanwser"+correctanwser);
        if(j == 3 ){
        Soldier.GetComponent<Animator>().enabled = true;
        SoldierPath.enabled = true;
        QuestionPanel.SetActive(false);
        ShowTexts();
        return;
                }

        if(j == 5 ){
        CorrectNumAnswersTXT.text = "ΟΙ σωστες απαντησεις απο το Quiz του κεφαλαιου ηταν: "+ correctanwser + 
                                    "\nΚαι οι λανθασμένες ηταν: " + (Answer.Length-correctanwser);
        QuestionPanel.SetActive(false);
        CanvasUI.SetActive(true);
        return;}
        
        ShowTexts();
        
     }

private void ShowTexts(){

    if (row< AnswersOption.GetLength(0)) {           
            ShowAnswersTXT.ForEach(TMPInButton => TMPInButton.text = AnswersOption[row, column++]);
            column = 0; row++;
            
            }
    QuestionPageTXT.text=Questions[questionrow++]; 
}

}
