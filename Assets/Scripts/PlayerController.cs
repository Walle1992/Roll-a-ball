using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //variables
    Rigidbody rb;
    [SerializeField] float speed = 5;
    public int count;
    public Text countText;
    public GameObject panel;
    public ParticleSystem fireParticle;
    public AudioClip pickUp;
    private AudioSource playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        //set text of score 
        countText.text = "Score: 0";
        rb = GetComponent<Rigidbody>();
        count = 0;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AddingForce();
    }
    void AddingForce()
    {
        if (count < 10)
        { //Adding force to Player
            float horzontalInput = Input.GetAxis("Horizontal");
            float veticatInput = Input.GetAxis("Vertical");
            rb.AddForce(Vector3.forward * veticatInput * speed);
            rb.AddForce(Vector3.right * horzontalInput * speed);
        }
        else
            GameOver();

    }
    //Detecte Trigger and Count number of PickUps
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.SetActive(false);
            count++;
            countText.text = "Score:  " + count;

            playerAudio.PlayOneShot(pickUp, 0.4f);
            fireParticle.Play();
        }

    }
    void GameOver()
    {
        panel.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
