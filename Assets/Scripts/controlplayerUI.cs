using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class controlplayerUI1 : MonoBehaviour
{
    public bool isPressedESC;
    public bool isClicked;

    public TMP_Text nameSkill;
    public TMP_Text descriptionSkill;

    public Image imageSkill;
    public Image imageSkillNull;
    public Image imageSkillHP;
    public Image imageSkillAttack;
    public Image imageSkillSpeed;

    public Transform panelSkill;
    public Transform panelSkillMore;

    public GameObject player;

    public 

    // Start is called before the first frame update
    void Start()
    {
        isPressedESC = isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPressedESC == false)
            {
                isPressedESC = true;
            }
            else
            {
                if(isClicked == true)
                {
                    isClicked = false;
                }
                else
                {
                    isPressedESC = false;
                }
            }
        }

        if(isPressedESC == true)
        {
            panelSkill.gameObject.SetActive(true);
        }
        else
        {
            panelSkill.gameObject.SetActive(false);
        }

        if (isClicked == true)
        {
            panelSkillMore.gameObject.SetActive(true);
        }
        else
        {
            panelSkillMore.gameObject.SetActive(false);
        }
    }

    public void pressAttack()
    {
        if (isClicked == false)
        {
            Clicking();
        }
        imageSkill.color = imageSkillAttack.color;
        nameSkill.text = "Damage bonus";
        descriptionSkill.text = "This skill give you more damage in your attacks";
    }

    public void pressHP()
    {
        if (isClicked == false)
        {
            Clicking();
        }
        imageSkill.color = imageSkillHP.color;
        nameSkill.text = "More HP";
        descriptionSkill.text = "This skill increase your Health Point";
    }

    public void pressSpeed()
    {
        if (isClicked == false)
        {
            Clicking();
        }
        imageSkill.color = imageSkillSpeed.color;
        nameSkill.text = "Speed+";
        descriptionSkill.text = "This skill make your speed more faster";
    }

    public void PressingESC()
    {
        if(isPressedESC == true)
        {
            if(isClicked == true)
            {
                isClicked = false;
            }
            else 
            {
                isPressedESC = false;
            }
        }
        else
        {
            isPressedESC = false;
        }
    }

    public void Clicking()
    {
        if (isClicked == false)
        {
            isClicked = true;
        }
        else
        {
            isClicked = false;
        }
    }
}
