using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    // ===== Variable declaration to hold reference to Rigidbody class component named "MyBallRigidbody"
    //public Rigidbody MyBallRigidbody;

    // ===== Variable declaration to hold reference to ScoreScript class component named "MyScoreScript"
    //public ScoreScript MyScoreScript;

    // ===== Variable declaration to hold reference to SoundScript class component named "MySoundScript"
    //public SoundScript MySoundScript;

    // ===== Start is called before the first frame update
    void Start()
    {
        // ===== Call AddForce function that exist on the RigidBody class component
        //MyBallRigidbody.AddForce(new Vector3(10,10,0), ForceMode.Impulse);
    }

    // ===== Update is called once per frame
    void Update()
    {
        
    }

    // ===== OnCollisionEnter is called whenever another collider intersects with the collider that is part of this gameobject
    private void OnCollisionEnter(Collision collision)
    {
        // ===== Check to see if the collider's gameobject's tag that we hit is named "WALL"
        if (collision.gameObject.tag == "WALL")
        {
            // ===== Call "MyAddToScore" function that exist on the ScoreScript class component
            //MyScoreScript.MyAddToScore();

            // ===== Call "MyPlaySound" function that exist on the SoundScript class component
            //MySoundScript.MyPlaySound(SoundType.HIT);
        }

        // ===== Check to see if the collider's gameobject's tag that we hit is named "PADDLE"
        if (collision.gameObject.tag == "PADDLE")
        {
            // ===== Call "MyPlaySound" function that exist on the SoundScript class component
            //MySoundScript.MyPlaySound(SoundType.HIT);
        }

        // ===== Check to see if the collider's gameobject's tag that we hit is named "LAVA"
        if (collision.gameObject.tag == "LAVA")
        {
            // ===== Call "LoadScene" function that exist on the SceneManager class
            //SceneManager.LoadScene("Main");
        }
    }
}
