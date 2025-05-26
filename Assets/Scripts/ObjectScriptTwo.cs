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

    // skaita, cik objekti ir pareizi novietoti
    [HideInInspector] public int placedCount = 0;
    public int totalObjects;

    // atsauce uz TimerScript (taimeri)
    public TimerScript timerScript;

    public WinnerScript winManager;

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

        // aprēķina kopējo objektu skaitu
        totalObjects = 7;

        // atrod TimerScript objektu ainā
        timerScript = FindObjectOfType<TimerScript>();

        if (winManager == null)
            winManager = FindObjectOfType<WinnerScript>();
    }

}
