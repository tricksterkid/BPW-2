using System.Collections;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    public GameObject Camera;
    public GameObject Player;

    private Animation cam;
    private Animation playerMove;
    private Animation playerJump;
    private Animation playerDissolve;

    void Start()
    {
        cam = Camera.GetComponent<Animation>();
        playerMove = Player.GetComponent<Animation>();
        playerJump = Player.GetComponent<Animation>();
        playerDissolve = Player.GetComponent<Animation>();
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
        playerJump.Play("CharacterJump");
        yield return new WaitForSeconds(2);
        Text2.SetActive(true);
        yield return new WaitForSeconds(2);
        Text2.SetActive(false);
        yield return new WaitForSeconds(2);
        playerDissolve.Play("CharacterDissolve");
        yield return new WaitForSeconds(2);
        Text3.SetActive(true);
    }
}
