using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.EventSystems;

public class HapticFeedbackOnUI : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    //연결된 컨트롤러
    public XRBaseController controller; 
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("선택");
        TriggerHapticFeddBack(0.2f, 1.0f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TriggerHapticFeddBack(0.1f, 0.5f);
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    //amplitude - 진동  duration - 지속시간
    private void TriggerHapticFeddBack(float amplitude, float duration)
    {
        if (controller != null) 
        { 
            //Haptic을 사용하게 해주는 함수
            controller.SendHapticImpulse(amplitude, duration);
        }
    }
}
