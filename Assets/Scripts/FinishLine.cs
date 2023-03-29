using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //[SerializeField]float loadDelay=0f;
    [SerializeField] ParticleSystem finishEffect;
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
        if(other.tag == "Finish")
        {
            Debug.Log("you finished");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",2f);
            finishEffect.Play();
            
        }
    }
    void ReloadScene()
    {
         SceneManager.LoadScene(0);
    }
}
