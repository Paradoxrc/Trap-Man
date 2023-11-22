using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish_flag : MonoBehaviour
    
{
    public itemCollector fk;
    

    [SerializeField] private AudioSource finishAudio;
    private bool levelCompleted=false;
    public GameObject bgmusic;
  
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fk=FindObjectOfType<itemCollector>();

        if (collision.gameObject.name == "player" && fk.cherries == 10 && !levelCompleted && SceneManager.GetActiveScene().buildIndex == 4)
        {
            bgmusic.GetComponent<AudioSource>().Stop();
            finishAudio.Play();
            Invoke("finishLevel", 3f);
            levelCompleted = true;

        }

        else if (collision.gameObject.name=="player" && fk.cherries==10 && !levelCompleted )
        {
            
            finishAudio.Play();
            Invoke("finishLevel", 2f);
            levelCompleted=true;
            
        }
        
    }


    void finishLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
