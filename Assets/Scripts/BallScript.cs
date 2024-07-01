using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public Rigidbody MyBallRigidbody;
    public ScoreScript MyScoreScript;
    public SoundScript MySoundScript;
    // Start is called before the first frame update
    void Start()
    {
        MyBallRigidbody.AddForce(new Vector3(10,10,0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WALL")
        {
            MyScoreScript.MyAddToScore();
            MySoundScript.MyPlaySound(SoundType.HIT);
        }
        if (collision.gameObject.tag == "PADDLE")
        {
            MySoundScript.MyPlaySound(SoundType.HIT);
        }
        if (collision.gameObject.tag == "LAVA")
        {
            SceneManager.LoadScene("Main");
        }
    }
}
