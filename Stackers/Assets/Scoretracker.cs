using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoretracker : MonoBehaviour
{
    public ScoreTracker INSTANCE;
    public int bestscore = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this;
            bestscore = 0;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
