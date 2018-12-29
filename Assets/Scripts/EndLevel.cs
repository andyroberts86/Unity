using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public string levelName;
    public AudioClip soundClip;
    public AudioSource mainMusic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            other.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("Here we go!");
            GetComponent<AudioSource>().PlayOneShot(soundClip);
            mainMusic.mute = true;
            StartCoroutine(DoAfterSound());
        }
    }

    IEnumerator DoAfterSound()
    {
        yield return new WaitForSeconds(soundClip.length);
        SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
    }
}
