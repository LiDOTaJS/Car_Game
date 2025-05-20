using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject schoolBus;
    public GameObject ambulance;

    public GameObject fireTruck;
    public GameObject cementTruck;
    public GameObject excavator;

    public GameObject e46Car;
    public GameObject e61Car;
    public GameObject tractor;

    public GameObject b2Car;
    public GameObject policeCar;
    public GameObject tractor2;

    [HideInInspector]
    public Vector2 garbageTruckPos;
    [HideInInspector]
    public Vector2 schoolBusPos;
    [HideInInspector]
    public Vector2 ambulancePos;
    
    [HideInInspector]
    public Vector2 fireTruckPos;
    [HideInInspector]
    public Vector2 cementTruckPos;
    [HideInInspector]
    public Vector2 excavatorPos;

    [HideInInspector]
    public Vector2 e46CarPos;
    [HideInInspector]
    public Vector2 e61CarPos;
    [HideInInspector]
    public Vector2 tractorPos;

    [HideInInspector]
    public Vector2 b2CarPos;
    [HideInInspector]
    public Vector2 policeCarPos;
    [HideInInspector]
    public Vector2 tractor2Pos;

    public AudioSource audioSource;
    public AudioClip[] audioClips;
    [HideInInspector]
    public bool rightPlace = false;
    public GameObject lastDragged = null;

    // Start is called before the first frame update
    void Start()
    {
        garbageTruckPos = garbageTruck.GetComponent<RectTransform>().localPosition;
        schoolBusPos = schoolBus.GetComponent<RectTransform>().localPosition;
        ambulancePos = ambulance.GetComponent<RectTransform>().localPosition;

        fireTruckPos = fireTruck.GetComponent<RectTransform>().localPosition;
        cementTruckPos = cementTruck.GetComponent<RectTransform>().localPosition;
        excavatorPos = excavator.GetComponent<RectTransform>().localPosition;

        e46CarPos = e46Car.GetComponent<RectTransform>().localPosition;
        e61CarPos = e61Car.GetComponent<RectTransform>().localPosition;
        tractorPos = tractor.GetComponent<RectTransform>().localPosition;

        b2CarPos = b2Car.GetComponent<RectTransform>().localPosition;
        policeCarPos = policeCar.GetComponent<RectTransform>().localPosition;
        tractor2Pos = tractor2.GetComponent<RectTransform>().localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
