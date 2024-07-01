using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyScoreText;
    public int MyScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyAddToScore()
    {
        MyScoreValue += 1;
        MyScoreText.text = MyScoreValue.ToString();
    }
}
