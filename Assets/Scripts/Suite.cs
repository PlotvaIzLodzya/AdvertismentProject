using UnityEngine;
using UnityEngine.UI;

public class Suite : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;

    private void Awake()
    {
        _toggle.onValueChanged.AddListener(delegate {
            CangeSuite(_toggle.isOn);
        });

        CangeSuite(_toggle.isOn);
    }

    public void CangeSuite(bool isActive)
    {
        gameObject.SetActive(isActive); 
    }
}
