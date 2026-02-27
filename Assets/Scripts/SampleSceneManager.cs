using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class SampleSceneManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_TextMeshPro.text = GameManager.Instance.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
