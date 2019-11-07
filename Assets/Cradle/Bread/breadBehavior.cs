using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;


public class breadBehavior : MonoBehaviour
{

    public Story story;
    public GameObject HuntingKnife;
    public GameObject KitchenKnife;
    public GameObject ButcherKnife;
    public GameObject ButterKnife;
    public GameObject SerratedKnife;


    //public GameObject bread;

    //void Start()

    // Start is called before the first frame update
    void Start()
    {

    story.Begin();
        HuntingKnife.SetActive(false);
        KitchenKnife.SetActive(false);
        ButcherKnife.SetActive(false);
        ButterKnife.SetActive(false);
        SerratedKnife.SetActive(false);
        Debug.Log("story begun");
}

    [StoryCue("The Bread Game","Enter")]

    void passage1_Enter()
    {
        
        Debug.Log("passage 1 begins");

    }


    [StoryCue("The Bread Game", "Exit")]
    void passage1_Exit()
    {
       
        Debug.Log("passage 1 exits");

    }

    [StoryCue("Cut your loaf of bread into slices", "Enter")]
    void passage17_Enter()
    {
        HuntingKnife.SetActive(true);
        KitchenKnife.SetActive(true);
        ButcherKnife.SetActive(true);
        ButterKnife.SetActive(true);
        SerratedKnife.SetActive(true);
        Debug.Log("passage 17 Enter");

    }
    [StoryCue("Cut your loaf of bread into slices", "Exit")]
    void passage17_Exit()
    {
        HuntingKnife.SetActive(false);
        KitchenKnife.SetActive(false);
        ButcherKnife.SetActive(false);
        ButterKnife.SetActive(false);
        SerratedKnife.SetActive(false);
        Debug.Log("passage 17 exits");

    }

}
