using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class r0cket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource rocketaudio;
    [SerializeField] float mainThrust; //up
    [SerializeField] float rcsThrust; //rotate
    bool _isSoundPlaying;
    bool godmode;
    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rocketaudio = GetComponent<AudioSource>();
        this._isSoundPlaying = false;
        godmode = false;
        rcsThrust = 140f;
        mainThrust = 130f;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.O))
        {
            if (godmode == true)
            {
                print("CHEAT DEACTIVATED");
                godmode = false;
            }
            else {
                print("CHEAT ACTIVATED");
                godmode = true;
            }
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            
            rigidbody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
            if (!_isSoundPlaying && Input.GetKeyDown(KeyCode.Space))
            {
                rocketaudio.Play();
                _isSoundPlaying = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            rocketaudio.Pause();
            _isSoundPlaying = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rcsThrust * Time.deltaTime);
            
         }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rcsThrust * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (godmode)
        {
            print("CHEAT ON");
        }
        else if (collision.gameObject.tag != "LaunchPad" && collision.gameObject.tag != "TargetPad")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (collision.gameObject.tag == "TargetPadLevel1")
        {
            SceneManager.LoadScene("level2");
        }
        else if (collision.gameObject.tag == "TargetPadLevel2")
        {
            SceneManager.LoadScene("Game");
        }


    }
}