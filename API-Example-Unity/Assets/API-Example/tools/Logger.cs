using UnityEngine;
using UnityEngine.UI;

public class Logger {
    Text text;

    public Logger(Text text) {
        this.text = text;
    }

    public void UpdateLog(string logMessage) {
        Debug.Log(logMessage);
        string srcLogMessage = text.text;
        if (srcLogMessage.Length > 500) {
            srcLogMessage = "";
        }
        srcLogMessage += "\r\n \r\n";
        srcLogMessage += logMessage;
        text.text = srcLogMessage;
    }

    public void DebugAssert(bool condition, string message) {
        if (!condition) {
            UpdateLog(message);
        }
        Debug.Assert(condition, message);
    }
}