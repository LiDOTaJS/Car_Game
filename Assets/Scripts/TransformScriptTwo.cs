using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScriptTwo : MonoBehaviour
{
    public ObjectScriptTwo objectScript;

    void Update()
    {
        if (objectScript.lastDragged != null)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                objectScript.lastDragged.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 30f);
            }

            if (Input.GetKey(KeyCode.X))
            {
                objectScript.lastDragged.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 30f);
            }

            // Invertēšana
            if (Input.GetKeyDown(KeyCode.C))
            {
                RectTransform rt = objectScript.lastDragged.GetComponent<RectTransform>();
                Vector3 currentScale = rt.localScale;
                currentScale.x *= -1;
                rt.localScale = currentScale;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                var rt = objectScript.lastDragged.GetComponent<RectTransform>();
                if (Mathf.Abs(rt.transform.localScale.y) < 1.5f)
                {
                    Vector3 scale = rt.transform.localScale;
                    scale.y += 0.001f * Mathf.Sign(scale.y == 0 ? 1 : scale.y);
                    rt.transform.localScale = scale;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                var rt = objectScript.lastDragged.GetComponent<RectTransform>();
                if (Mathf.Abs(rt.transform.localScale.y) > 0.5f)
                {
                    Vector3 scale = rt.transform.localScale;
                    scale.y -= 0.001f * Mathf.Sign(scale.y == 0 ? 1 : scale.y);
                    rt.transform.localScale = scale;
                }
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                var rt = objectScript.lastDragged.GetComponent<RectTransform>();
                if (Mathf.Abs(rt.transform.localScale.x) > 0.5f)
                {
                    Vector3 scale = rt.transform.localScale;
                    scale.x -= 0.001f * Mathf.Sign(scale.x == 0 ? 1 : scale.x);
                    rt.transform.localScale = scale;
                }
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                var rt = objectScript.lastDragged.GetComponent<RectTransform>();
                if (Mathf.Abs(rt.transform.localScale.x) < 1.5f)
                {
                    Vector3 scale = rt.transform.localScale;
                    scale.x += 0.001f * Mathf.Sign(scale.x == 0 ? 1 : scale.x);
                    rt.transform.localScale = scale;
                }
            }
        }
    }
}
