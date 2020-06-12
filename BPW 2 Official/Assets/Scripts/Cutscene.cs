using System.Collections;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    public GameObject Camera;
    public GameObject Player;

    public GameObject Cloud1;
    public GameObject Cloud2;
    public GameObject Cloud3;
    public GameObject Cloud4;

    private Animation cam;
    private Animation playerMove;
    private Animation playerJump;
    private Animation playerShake;
    private Animation playerDissolve;

    private Animation appearCloud1;
    private Animation appearCloud2;
    private Animation appearCloud3;
    private Animation appearCloud4;

    void Start()
    {
        cam = Camera.GetComponent<Animation>();
        playerMove = Player.GetComponent<Animation>();
        playerJump = Player.GetComponent<Animation>();
        playerShake = Player.GetComponent<Animation>();
        playerDissolve = Player.GetComponent<Animation>();

        appearCloud1 = Cloud1.GetComponent<Animation>();
        appearCloud2 = Cloud2.GetComponent<Animation>();
        appearCloud3 = Cloud3.GetComponent<Animation>();
        appearCloud4 = Cloud4.GetComponent<Animation>();


        StartCoroutine(CutscenePlay());
    }

    IEnumerator CutscenePlay()
    {
        playerMove.Play("CharacterWalk");
        cam.Play("CameraMovement");
        yield return new WaitForSeconds(2);
        Text1.SetActive(true);
        yield return new WaitForSeconds(2);
        Text1.SetActive(false);
        Cloud1.SetActive(true);
        Cloud2.SetActive(true);
        Cloud3.SetActive(true);
        Cloud4.SetActive(true);
        appearCloud1.Play("Cloud1");
        appearCloud2.Play("Cloud2");
        appearCloud3.Play("Cloud3");
        appearCloud4.Play("Cloud4");
        yield return new WaitForSeconds(2);
        playerJump.Play("CharacterJump");
        Text2.SetActive(true);
        yield return new WaitForSeconds(2);
        Text2.SetActive(false);
        playerShake.Play("CharacterShake");
        yield return new WaitForSeconds(2);
        playerDissolve.Play("CharacterDissolve");
        yield return new WaitForSeconds(2);
        Text3.SetActive(true);
    }
}
