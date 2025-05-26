using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceScriptTwo : MonoBehaviour, IDropHandler
{

    private float placeZRotation, carZRotation, difZRotation;
    private Vector2 placeSize, carSize;
    private float xSizeDif, ySizeDif;
    public ObjectScriptTwo objectScript;
    public void OnDrop(PointerEventData eventData)
    {
        if ((eventData.pointerDrag != null) && Input.GetMouseButtonUp(0) && Input.GetMouseButton(2) == false)
        {
            if (eventData.pointerDrag.tag.Equals(tag))
            {
                placeZRotation = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
                carZRotation = GetComponent<RectTransform>().transform.eulerAngles.z;

                difZRotation = Mathf.Abs(placeZRotation - carZRotation);
                Debug.Log("Dif Z Rotation: " + difZRotation);

                placeSize = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                carSize = GetComponent<RectTransform>().localScale;
                xSizeDif = Mathf.Abs(Mathf.Abs(placeSize.x) - Mathf.Abs(carSize.x));
                ySizeDif = Mathf.Abs(Mathf.Abs(placeSize.y) - Mathf.Abs(carSize.y));

                Debug.Log("Dif X Size: " + xSizeDif + "\nDif Y Size: " + ySizeDif);

                if ((difZRotation <= 10 || (difZRotation >= 350 && difZRotation <= 360)) && (xSizeDif <= 0.3 && ySizeDif <= 0.3))
                {
                    Debug.Log("Right Place");
                    objectScript.rightPlace = true;
                    //Izcentre poziciju
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    //Pielago rotaciju
                    eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
                    //Pielago izmeru
                    eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
                    switch (eventData.pointerDrag.tag)
                    {

                        //2. Limenis
                        case "YellowCar":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[2]);
                            break;
                        case "Truck":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[3]);
                            break;
                        case "Formula":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[4]);
                            break;
                        case "Tank":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[5]);
                            break;
                        case "Bike":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[6]);
                            break;
                        case "Lawn":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[7]);
                            break;
                        case "JetSki":
                            objectScript.audioSource.PlayOneShot(objectScript.audioClips[8]);
                            break;
                    }
                    // palielina novietoto objektu skaitu tikai vienreiz katram objektam
                    if (objectScript.lastDragged != eventData.pointerDrag)
                    {
                        objectScript.placedCount++;
                        objectScript.lastDragged = eventData.pointerDrag;

                        // Ja visi objekti ir novietoti, apstādina taimeri
                        if (objectScript.placedCount >= objectScript.totalObjects)
                        {
                            // // TimerScript.StopTimer() apstādina taimeri
                            objectScript.timerScript.StopTimer();
                            // Rāda uzvaras logu
                            objectScript.winManager.ShowWinWindow();
                        }
                    }
                    return;
                }
            }

            }
            else
            {
                objectScript.rightPlace = false;
                objectScript.audioSource.PlayOneShot(objectScript.audioClips[1]);

                switch (eventData.pointerDrag.tag)
                {

                    //2. Limenis
                    case "YellowCar":
                        objectScript.yellowCar.GetComponent<RectTransform>().localPosition = objectScript.yellowCarPos;
                        break;
                    case "Truck":
                        objectScript.redTruck.GetComponent<RectTransform>().localPosition = objectScript.redTruckPos;
                        break;
                    case "Formula":
                        objectScript.formula.GetComponent<RectTransform>().localPosition = objectScript.formulaPos;
                        break;
                    case "Tank":
                        objectScript.tank.GetComponent<RectTransform>().localPosition = objectScript.tankPos;
                        break;
                    case "Bike":
                        objectScript.motorcycle.GetComponent<RectTransform>().localPosition = objectScript.motorcyclePos;
                        break;
                    case "Lawn":
                        objectScript.lawnMower.GetComponent<RectTransform>().localPosition = objectScript.lawnMowerPos;
                        break;
                    case "JetSki":
                        objectScript.jetSki.GetComponent<RectTransform>().localPosition = objectScript.jetSkiPos;
                        break;
                    default:
                        Debug.LogError("Unknown tag!");
                        break;
                }

            }




        }
    }

