using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Newjoke : MonoBehaviour
{
    public TextMeshProUGUI Jokes;
    // Start is called before the first frame update


    public void Joke()
    {
           Joke j=ApiHelper.getnewjoke();
           Jokes.text = j.value;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
