using System;
using System.Windows.Controls;
using SimpleLoggingSystem;

namespace SimpleTwitchHelper
{
    public class CustomLog
    {
        private readonly TextBox textBox;

        public CustomLog(TextBox textBox)
        {
            this.textBox = textBox;

            Globals.Logger.OnLog += UpdateTextBox;
        }

        private void UpdateTextBox(LogEntry entry)
        {
            if (textBox == null)
                return;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Don't know. Makes no sense.
                //foreach (var ent in Globals.Logger.log)
                //{
                //    textBox.Text += ent + Environment.NewLine;
                //}
                textBox.Text += entry + Environment.NewLine;
            }
            else
            {
                textBox.Text += entry + Environment.NewLine;
            }
        }

        public static void LogWrapper(string message)
        {
            Globals.Logger.Log(message);
        }
    }
}