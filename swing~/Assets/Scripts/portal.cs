using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource portalsound;
    void Start()
    {
        portalsound=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            portalsound.Play();
            Invoke("finishlevel", 1f);
            finishlevel();
        }
    }
    private void finishlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
