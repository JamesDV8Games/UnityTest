using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public string text="Hello and welcome to my game!";
    [SerializeField]
    int roundnumber=5;
    [Range(-10,10)]
    public float number=6f;
    public bool IsIt;
    public GameObject ThingIWantToFindLater;

    GameObject gameobject;
    Transform address;

    public Text textfield;


    // Start is called before the first frame update
    void Start()
    {
        if (ThingIWantToFindLater!=null)
        {
            print("The thing that I found that I want to find later is " + ThingIWantToFindLater.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        textfield.text = "" + ThingIWantToFindLater.transform.ToString();
    }
}
