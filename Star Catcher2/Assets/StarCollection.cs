using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollection : MonoBehaviour {

    private int count = 0;
    public int currentScore;
    public Text countText;
    public AudioClip deathClip;

    AudioSource playerAudio;
    //bool isDead;
    bool damaged;

	void Start () {
        //count = 0;
        SetCountText();
	}

    void Awake()
    {
        playerAudio = GetComponent<AudioSource>();
        currentScore = count;
    }
	
	void Update ()
    {
        damaged = false;
	}

    public void TakeDamage (int amount)
    {
        damaged = true;
        currentScore -= amount;
        playerAudio.Play();

        /*if (currentScore <= 0 && !isDead)
        {
            Death ();
        }*/
    }

    /*void Death()
    {
        isDead = true;
        playerAudio.clip = deathClip;
        playerAudio.Play();
    }*/

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           other.gameObject.SetActive(false);
           count = count + 1;
           //SetCountText();
        }
        else if (other.gameObject.CompareTag("Drop"))
        {
            count = count - 1;
            //SetCountText();
        }

        SetCountText();

        //if (other.gameObject.CompareTag("Drop"))
        //{
            //count = count - 1;
            //SetCountText();
        //}
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
