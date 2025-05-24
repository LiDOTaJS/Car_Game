using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScriptTwo : MonoBehaviour
{

    //2. Limenis
    public GameObject yellowCar;
    public GameObject redTruck;
    public GameObject formula;
    public GameObject tank;
    public GameObject motorcycle;
    public GameObject lawnMower;
    public GameObject jetSki;

    [HideInInspector]
    public Vector2 yellowCarPos;
    [HideInInspector]
    public Vector2 redTruckPos;
    [HideInInspector]
    public Vector2 formulaPos;
    [HideInInspector]
    public Vector2 tankPos;
    [HideInInspector]
    public Vector2 motorcyclePos;
    [HideInInspector]
    public Vector2 lawnMowerPos;
    [HideInInspector]
    public Vector2 jetSkiPos;

    public AudioSource audioSource;
    public AudioClip[] audioClips;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;

    // NEW: count how many unique objects have been placed
    [HideInInspector] public int placedCount = 0;
    public int totalObjects;

    // NEW: reference to your TimerScript
    public TimerScript timerScript;

    public WinnerScriptTwo winManager;

    // Start is called before the first frame update
    void Start()
    {
        
        //2. Limenis
        yellowCarPos = yellowCar.GetComponent<RectTransform>().localPosition;
        redTruckPos = redTruck.GetComponent<RectTransform>().localPosition;
        formulaPos = formula.GetComponent<RectTransform>().localPosition;
        tankPos = tank.GetComponent<RectTransform>().localPosition;
        motorcyclePos = motorcycle.GetComponent<RectTransform>().localPosition;
        lawnMowerPos = lawnMower.GetComponent<RectTransform>().localPosition;
        jetSkiPos = jetSki.GetComponent<RectTransform>().localPosition;

        // NEW: calculate total draggables (you have 7)
        totalObjects = 7;

        // NEW: find the TimerScript in scene
        timerScript = FindObjectOfType<TimerScript>();

        if (winManager == null)
            winManager = FindObjectOfType<WinnerScriptTwo>();
    }

}
