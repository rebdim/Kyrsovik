using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kyrsovik.ClassFolder
{
    internal class MBClass
    {
        public static void InfoMB(string text)
        {
            MessageBox.Show(text, "Информация",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void ErrorMB(string message)
        {
            MessageBox.Show(message, "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void ErrorMB(Exception message)
        {
            MessageBox.Show(message.Message, "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static bool QuestionMB(string text)
        {
            return MessageBoxResult.Yes == MessageBox.Show(text,
                "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        public static void ExitMB()
        {
            bool resultMB = QuestionMB("Вы действительно" +
               "хотите выйти?");
            if (resultMB)
                App.Current.Shutdown();
        }
    }
}
