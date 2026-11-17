using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WatherBar : MonoBehaviour
{
    private Slider slider;
    public TextMeshProUGUI hydrationCounter;

    public GameObject playerState;

    private float currentHydration, maxHydration;

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHydration = playerState.GetComponent<PlayerState>().currentHydrationPerecent;
        maxHydration = playerState.GetComponent<PlayerState>().maxHydrationPerecent;

        float fillValue = currentHydration / maxHydration;
        slider.value = fillValue;
        hydrationCounter.text = currentHydration + "/" + maxHydration;

    }
}
