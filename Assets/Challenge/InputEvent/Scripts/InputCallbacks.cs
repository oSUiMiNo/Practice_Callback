using UnityEngine;

// キー打った時のイベント
public class InputCallbacks : MonoBehaviour
{
    public static event System.Action OnKeyDown_A;
    public static event System.Action OnKeyDown_B;
    public static event System.Action OnKeyDown_C;
    public static event System.Action OnKeyDown_D;
    public static event System.Action OnKeyDown_E;
    public static event System.Action OnKeyDown_F;
    public static event System.Action OnKeyDown_G;
    public static event System.Action OnKeyDown_H;
    public static event System.Action OnKeyDown_I;
    public static event System.Action OnKeyDown_J;
    public static event System.Action OnKeyDown_K;
    public static event System.Action OnKeyDown_L;
    public static event System.Action OnKeyDown_M;
    public static event System.Action OnKeyDown_N;
    public static event System.Action OnKeyDown_O;
    public static event System.Action OnKeyDown_P;
    public static event System.Action OnKeyDown_Q;
    public static event System.Action OnKeyDown_R;
    public static event System.Action OnKeyDown_S;
    public static event System.Action OnKeyDown_T;
    public static event System.Action OnKeyDown_U;
    public static event System.Action OnKeyDown_V;
    public static event System.Action OnKeyDown_W;
    public static event System.Action OnKeyDown_X;
    public static event System.Action OnKeyDown_Y;
    public static event System.Action OnKeyDown_Z;

    public static event System.Action OnKey_A;
    public static event System.Action OnKey_B;
    public static event System.Action OnKey_C;
    public static event System.Action OnKey_D;
    public static event System.Action OnKey_E;
    public static event System.Action OnKey_F;
    public static event System.Action OnKey_G;
    public static event System.Action OnKey_H;
    public static event System.Action OnKey_I;
    public static event System.Action OnKey_J;
    public static event System.Action OnKey_K;
    public static event System.Action OnKey_L;
    public static event System.Action OnKey_M;
    public static event System.Action OnKey_N;
    public static event System.Action OnKey_O;
    public static event System.Action OnKey_P;
    public static event System.Action OnKey_Q;
    public static event System.Action OnKey_R;
    public static event System.Action OnKey_S;
    public static event System.Action OnKey_T;
    public static event System.Action OnKey_U;
    public static event System.Action OnKey_V;
    public static event System.Action OnKey_W;
    public static event System.Action OnKey_X;
    public static event System.Action OnKey_Y;
    public static event System.Action OnKey_Z;

    public static event System.Action OnKeyDown_Space;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) OnKeyDown_A?.Invoke();
        if (Input.GetKeyDown(KeyCode.B)) OnKeyDown_B?.Invoke();
        if (Input.GetKeyDown(KeyCode.C)) OnKeyDown_C?.Invoke();
        if (Input.GetKeyDown(KeyCode.D)) OnKeyDown_D?.Invoke();
        if (Input.GetKeyDown(KeyCode.E)) OnKeyDown_E?.Invoke();
        if (Input.GetKeyDown(KeyCode.F)) OnKeyDown_F?.Invoke();
        if (Input.GetKeyDown(KeyCode.G)) OnKeyDown_G?.Invoke();
        if (Input.GetKeyDown(KeyCode.H)) OnKeyDown_H?.Invoke();
        if (Input.GetKeyDown(KeyCode.I)) OnKeyDown_I?.Invoke();
        if (Input.GetKeyDown(KeyCode.J)) OnKeyDown_J?.Invoke();
        if (Input.GetKeyDown(KeyCode.K)) OnKeyDown_K?.Invoke();
        if (Input.GetKeyDown(KeyCode.L)) OnKeyDown_L?.Invoke();
        if (Input.GetKeyDown(KeyCode.M)) OnKeyDown_M?.Invoke();
        if (Input.GetKeyDown(KeyCode.N)) OnKeyDown_N?.Invoke();
        if (Input.GetKeyDown(KeyCode.O)) OnKeyDown_O?.Invoke();
        if (Input.GetKeyDown(KeyCode.P)) OnKeyDown_P?.Invoke();
        if (Input.GetKeyDown(KeyCode.Q)) OnKeyDown_Q?.Invoke();
        if (Input.GetKeyDown(KeyCode.R)) OnKeyDown_R?.Invoke();
        if (Input.GetKeyDown(KeyCode.S)) OnKeyDown_S?.Invoke();
        if (Input.GetKeyDown(KeyCode.T)) OnKeyDown_T?.Invoke();
        if (Input.GetKeyDown(KeyCode.U)) OnKeyDown_U?.Invoke();
        if (Input.GetKeyDown(KeyCode.V)) OnKeyDown_V?.Invoke();
        if (Input.GetKeyDown(KeyCode.W)) OnKeyDown_W?.Invoke();
        if (Input.GetKeyDown(KeyCode.X)) OnKeyDown_X?.Invoke();
        if (Input.GetKeyDown(KeyCode.Y)) OnKeyDown_Y?.Invoke();
        if (Input.GetKeyDown(KeyCode.Z)) OnKeyDown_Z?.Invoke();

        if (Input.GetKey(KeyCode.A)) OnKey_A?.Invoke();
        if (Input.GetKey(KeyCode.B)) OnKey_B?.Invoke();
        if (Input.GetKey(KeyCode.C)) OnKey_C?.Invoke();
        if (Input.GetKey(KeyCode.D)) OnKey_D?.Invoke();
        if (Input.GetKey(KeyCode.E)) OnKey_E?.Invoke();
        if (Input.GetKey(KeyCode.F)) OnKey_F?.Invoke();
        if (Input.GetKey(KeyCode.G)) OnKey_G?.Invoke();
        if (Input.GetKey(KeyCode.H)) OnKey_H?.Invoke();
        if (Input.GetKey(KeyCode.I)) OnKey_I?.Invoke();
        if (Input.GetKey(KeyCode.J)) OnKey_J?.Invoke();
        if (Input.GetKey(KeyCode.K)) OnKey_K?.Invoke();
        if (Input.GetKey(KeyCode.L)) OnKey_L?.Invoke();
        if (Input.GetKey(KeyCode.M)) OnKey_M?.Invoke();
        if (Input.GetKey(KeyCode.N)) OnKey_N?.Invoke();
        if (Input.GetKey(KeyCode.O)) OnKey_O?.Invoke();
        if (Input.GetKey(KeyCode.P)) OnKey_P?.Invoke();
        if (Input.GetKey(KeyCode.Q)) OnKey_Q?.Invoke();
        if (Input.GetKey(KeyCode.R)) OnKey_R?.Invoke();
        if (Input.GetKey(KeyCode.S)) OnKey_S?.Invoke();
        if (Input.GetKey(KeyCode.T)) OnKey_T?.Invoke();
        if (Input.GetKey(KeyCode.U)) OnKey_U?.Invoke();
        if (Input.GetKey(KeyCode.V)) OnKey_V?.Invoke();
        if (Input.GetKey(KeyCode.W)) OnKey_W?.Invoke();
        if (Input.GetKey(KeyCode.X)) OnKey_X?.Invoke();
        if (Input.GetKey(KeyCode.Y)) OnKey_Y?.Invoke();
        if (Input.GetKey(KeyCode.Z)) OnKey_Z?.Invoke();

        if (Input.GetKey(KeyCode.Space)) OnKeyDown_Space?.Invoke();
    }
}
