using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text gameText;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text statusText;

    public AudioClip[] testingSounds;
    public AudioClip failureSound;
    public AudioSource m_audioSource;

    private float reactionTime, startTime, totalTime;
    private bool clockIsTicking, timerCanBeStopped, gameStarted;
    private int counter, score;
    public int selected;

    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        counter = 30;
        score = 0;
        reactionTime = 0f;
        startTime = 0f;
        totalTime = 0f;
        gameText.text = "---";
        scoreText.text = "---";
        statusText.text = "Left Click to Begin!";
        clockIsTicking = false;
        gameStarted = false;
        timerCanBeStopped = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            if (counter > 0) 
            { 
                if (Input.GetMouseButtonDown(0) && !gameStarted)
                {
                    StartCoroutine("StartMeasuring");
                    gameText.text = "Wait";
                    scoreText.text = score.ToString();
                    statusText.text = "Listen for the sound!";
                    clockIsTicking = true;
                    timerCanBeStopped = false;
                    gameStarted = true;
                }
                else
                {
                    if (Input.GetKeyDown("[1]") && selected == 0)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }
                    

                    }
                    else if (Input.GetKeyDown("[2]") && selected == 1)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[3]") && selected == 2)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[4]") && selected == 3)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[6]") && selected == 4)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[7]") && selected == 5)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[8]") && selected == 6)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else if (Input.GetKeyDown("[9]") && selected == 7)
                    {
                        if (clockIsTicking && timerCanBeStopped)
                        {
                            StopCoroutine("StartMeasuring");
                            reactionTime = Time.time - startTime;
                            totalTime += reactionTime;
                            gameText.text = reactionTime.ToString("N3");
                            score += 1;
                            scoreText.text = score.ToString();
                            counter -= 1;
                            clockIsTicking = false;
                        }

                        if(counter != 0)
                        {
                                StartCoroutine("StartMeasuring");
                                scoreText.text = score.ToString();
                                clockIsTicking = true;
                                timerCanBeStopped = false;
                        }

                    }
                    else
                    {
                        //play wrong sound
                        if (!Input.GetMouseButtonDown(0))
                        {
                            m_audioSource.PlayOneShot(failureSound);
                        }
                            
                    }
                }
            }
            
        }
        if(counter == 0)
        {
            statusText.text = "Score: " + score.ToString() + "\nAverage Speed: " + (totalTime / score).ToString("N3") + "s";
        }
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    private IEnumerator StartMeasuring()
    {
        yield return new WaitForSeconds(1f);
        //indicate that reaction must be made (play sound now)
        selected = Random.Range(0, 8);
        //Debug.Log(selected);
        m_audioSource.PlayOneShot(testingSounds[selected]);

        startTime = Time.time;
        clockIsTicking = true;
        timerCanBeStopped = true;
    }
}
