using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlowText : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float glowStrength = 1f;
    public float glowSpeed = 1f;

    private Material textMaterial;
    private Color startColor;

    void Start()
    {
        textMaterial = textMesh.fontMaterial;
        startColor = textMaterial.GetColor("_GlowColor");
    }

    void Update()
    {
        // Animar el efecto de neón
        float glow = Mathf.PingPong(Time.time * glowSpeed, 1f);
        Color glowColor = startColor * Mathf.LinearToGammaSpace(glowStrength * glow);
        textMaterial.SetColor("_GlowColor", glowColor);
    }
}
