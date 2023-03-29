using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]float loadDelay=0f;
    ParticleSystem fastEffect;
    [SerializeField] AudioClip dead_sound;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Floor")
        {
            Debug.Log("YOU ARE DEAD");
            GetComponent<AudioSource>().PlayOneShot(dead_sound);
            Invoke("ReloadScene",loadDelay);
            
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0); 
    }
}
