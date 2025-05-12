using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    public GameObject garbageTruck;
    public GameObject schoolBus;
    public GameObject ambulance;

    [HideInInspector]
    public Vector2 garbageTruckPos;
    [HideInInspector]
    public Vector2 schoolBusPos;
    [HideInInspector]
    public Vector2 ambulancePos;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
