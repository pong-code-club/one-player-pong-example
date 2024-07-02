using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // ===== Variable declaration to hold reference to TextMeshProUGUI class component named "MyScoreText"
    //public TextMeshProUGUI MyScoreText;

    // ===== Variable declaration to holds a whole number value (int) that is named "MyScoreValue"
    //public int MyScoreValue;

    // ===== Start is called before the first frame update
    void Start()
    {
        
    }

    // ===== Update is called once per frame
    void Update()
    {
        
    }

    // ===== Declare function named "MyAddToScore"
    public void MyAddToScore()
    {
        // ===== Add 1 to the whole number value (int) that is stored in the variable named "MyScoreValue"
        //MyScoreValue += 1;

        // ===== Set the variable named "text" that exist on the TextMeshProUGUI class component named "MyScoreText" to "MyScoreValue"
        // ===== NOTE: You must convert the value stored in "MyScoreValue" from an int to a string for this to work, hence the "ToString" function call
        //MyScoreText.text = MyScoreValue.ToString();
    }
}
