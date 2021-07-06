using TMPro;
using UnityEngine;

public class TMPSetter : MonoBehaviour
{
    private TextMeshPro _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshPro>();
    }

    public void SetFloat(float num)
    {
        _text.text = ((int)num).ToString();
    }
}
