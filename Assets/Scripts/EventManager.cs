using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static event UnityAction ClickedThing;
    public static void OnClickedThing() => ClickedThing?.Invoke();

    public static event UnityAction ReleasedThing;
    public static void OnReleasedThing() => ReleasedThing?.Invoke();
}
