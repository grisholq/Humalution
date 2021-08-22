using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatUI : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _level;
    [SerializeField] private Button _upButton;

    public void SetStat(Stat stat)
    {
        _image.texture = stat.Data.Image;
        _name.text = stat.Data.Name;
        _level.text = stat.Data.Name;
        _upButton.onClick.AddListener(stat.LevelUp);
    }
}