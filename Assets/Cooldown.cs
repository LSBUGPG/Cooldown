using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cooldown : MonoBehaviour
{
    public float cooldownTime = 1.0f;
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.0f;
    }

    void UpdateCooldown()
    {
        if (image.fillAmount > 0.0f)
        {
            image.fillAmount -= Time.deltaTime / cooldownTime;
            if (image.fillAmount < 0.0f)
            {
                image.fillAmount = 0.0f;
            }
        }
    }

    void Update()
    {
        UpdateCooldown();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsCool())
            {
                Debug.Log("Do thing!");
                image.fillAmount = 1.0f;
            }
            else
            {
                Debug.Log("Wait for cooldown!");
            }
        }
    }

    public bool IsCool()
    {
        return image.fillAmount == 0.0f;
    }
}
