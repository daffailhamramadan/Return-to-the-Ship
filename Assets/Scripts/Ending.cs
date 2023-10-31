using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ending : MonoBehaviour
{
    [SerializeField] private Animator anim;

    [SerializeField] private GameObject endingText;

    [SerializeField] private VideoPlayer videoPlayer;

    [SerializeField] private GameObject videoTexture;

    [SerializeField] private AudioSource backgroundMusic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(EndingScene());
        }
    }

    IEnumerator EndingScene()
    {
        endingText.SetActive(true);
        yield return new WaitForSeconds(3f);
        anim.SetTrigger("Ending");
        yield return new WaitForSeconds(10f);
        backgroundMusic.Stop();
        videoPlayer.Play();
        yield return new WaitForSeconds(0.2f);
        videoTexture.SetActive(true);
    }
}
