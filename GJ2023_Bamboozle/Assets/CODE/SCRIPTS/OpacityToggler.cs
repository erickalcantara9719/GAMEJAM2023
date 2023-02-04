using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityToggler : MonoBehaviour
{
    public Material material;
    public float interval = 1f;

    private Color originalColor;

    private void Start()
    {
        originalColor = material.color;
        StartCoroutine(ToggleOpacity());
    }

    private IEnumerator ToggleOpacity()
    {
        while (true)
        {
            material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0);
            yield return new WaitForSeconds(interval);
            material.color = originalColor;
            yield return new WaitForSeconds(interval);
        }
    }
}
