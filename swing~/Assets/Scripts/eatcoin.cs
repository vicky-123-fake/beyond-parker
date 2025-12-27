using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class eatcoin : MonoBehaviour
{
    public int score=0;
    public TMP_Text ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("coin"))
        {
            score++;
            ui.text = "score:" + score;
            Destroy(other.gameObject);
        }
    }
}
