using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text gameText;
    

    public AudioClip[] testingSounds;
    public AudioSource m_audioSource;

    private float reactionTime, startTime;
    private bool clockIsTicking, timerCanBeStopped;
    private int selected;
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();

        reactionTime = 0f;
        startTime = 0f;
        gameText.text = "---";
        clockIsTicking = false;
        timerCanBeStopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!clockIsTicking)
            {
                StartCoroutine("StartMeasuring");
                gameText.text = "Wait";
                //indicate waiting for reaction (play sound)
                clockIsTicking = true;
                timerCanBeStopped = false;
            } 
        }
        if (Input.GetKeyDown("[4]"))
        {
            if (clockIsTicking && timerCanBeStopped)
            {
                StopCoroutine("StartMeasuring");
                reactionTime = Time.time - startTime;
                gameText.text = reactionTime.ToString("N3");
                clockIsTicking = false;
            }
            else if (clockIsTicking && !timerCanBeStopped)
            {
                StopCoroutine("StartMeasuring");
                reactionTime = 0f;
                clockIsTicking = false;
                timerCanBeStopped = true;
                gameText.text = "Too early";
            }
        }
    }

    private IEnumerator StartMeasuring()
    {
        //randomDelayBeforeMeasuring = Random.Range(0.5f, 5f);
        yield return new WaitForSeconds(3f);
        //indicate that reaction must be made (play sound now)
        selected = Random.Range(0, 8);
        Debug.Log(selected);
        m_audioSource.PlayOneShot(testingSounds[selected]);

        startTime = Time.time;
        clockIsTicking = true;
        timerCanBeStopped = true;
    }
}
