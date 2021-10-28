using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public float MoveTime;
    public Transform ObjectToMove;
    public Transform From;
    public Transform To;
    void Start()
    {
        StartCoroutine(StartMovingObject());
    }

    private IEnumerator MoveFromTo(Vector3 from, Vector3 to)
    {
        for (var t = 0f; t <= 1f; t += Time.deltaTime / MoveTime)
        {
            yield return null;
            ObjectToMove.position = Vector3.Lerp(from, to, t);
        }
        ObjectToMove.position = to;
    }

    private IEnumerator StartMovingObject()
    {
        //while (true)
        //{
        //    yield return MoveFromTo(From.position, To.position);
        //    yield return MoveFromTo(To.position, From.position);
        //}
        yield return MoveFromTo(From.position, To.position);
        Destroy(gameObject);
    }


}
