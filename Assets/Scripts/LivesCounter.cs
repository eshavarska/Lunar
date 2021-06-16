using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesCounter : MonoBehaviour
{
    private TextMeshProUGUI livesCounter;

    // Start is called before the first frame update
    void Start()
    {
        livesCounter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        livesCounter.text = Moth.Lives.ToString();
    }
}
