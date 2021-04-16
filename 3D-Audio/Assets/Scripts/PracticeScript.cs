using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeScript : MonoBehaviour
{

    public AudioClip[] practiceSounds;
    public AudioSource m_audioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("[1]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[0]);
        }
        else if (Input.GetKeyDown("[2]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[1]);
        }
        else if (Input.GetKeyDown("[3]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[2]);

        }
        else if (Input.GetKeyDown("[4]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[3]);

        }
        else if (Input.GetKeyDown("[6]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[4]);

        }
        else if (Input.GetKeyDown("[7]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[5]);

        }
        else if (Input.GetKeyDown("[8]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[6]);

        }
        else if (Input.GetKeyDown("[9]"))
        {
            m_audioSource.PlayOneShot(practiceSounds[7]);

        }
    }
}
