using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Died : MonoBehaviour
{
    public Text textHints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.tag == "Player" )
         textHints.SendMessage("ShowHint", "Pożarty przez wilka");
        //  SceneManager.LoadScene("Menu");
    }
}
