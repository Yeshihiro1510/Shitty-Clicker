using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    // Speed of Sin loop
    public float speed = 1;
    // Offset of Sin from zero
    public float offset = 1;
    // The amplitude of Sin
    public float range = 1;
    
    private void Update()
    {
        transform.localScale = (Mathf.Sin(Time.time * speed) * range + offset) * Vector3.one;
    }
}