using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class LOCALE_SELECTOR : MonoBehaviour
{
    private bool active = false;
    public void ChangeLocale(int localeID)
    {

        if (active == true) // 如果已經啟動，再次呼叫時就直接取消(return)
            return;
        StartCoroutine(SetLocale(localeID));
    }


    IEnumerator SetLocale(int  _localeID)
    {
        active = true;

        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID]; //將預設locale設定成指定國家id，tw 0 eng 1

        active = false;
    }
}
