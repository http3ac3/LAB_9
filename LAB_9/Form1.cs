using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_9
{
    public partial class Form1 : Form
    {
        string openText;
        string keyWord;
        char[] alphabet = {'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п',
                           'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public Form1()
        {
            InitializeComponent();
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            openText = OpenTextTB.Text.ToLower();
            keyWord = KeyWordTB.Text.ToLower();

            string s = "";
            for (int i = 0, c = 0; i < openText.Length; i++, c++)
            {
                if (i % keyWord.Length == 0 && i > 0) c = 0;
                s += keyWord[c];
            }
            
            string cipheredText = "";
            for (int i = 0; i < openText.Length; i++)
            {
                int keyWordIndex = Array.IndexOf(alphabet, s[i]);
                int openTextIndex = Array.IndexOf(alphabet, openText[i]);
                cipheredText += alphabet[(keyWordIndex + openTextIndex + 1) % 32];
            }

            AnswerTB.Text = $"Зашифрованное слово >> {cipheredText}";
        }

        private void DecipherButtom_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            openText = OpenTextTB.Text.ToLower();
            keyWord = KeyWordTB.Text.ToLower();

            string s = "";
            for (int i = 0, c = 0; i < openText.Length; i++, c++)
            {
                if (i % keyWord.Length == 0 && i > 0) c = 0;
                s += keyWord[c];
            }

            string decipheredText = "";
            for (int i = 0; i < openText.Length; i++)
            {
                int keyWordIndex = Array.IndexOf(alphabet, s[i]);
                int openTextIndex = Array.IndexOf(alphabet, openText[i]);
                decipheredText += alphabet[(openTextIndex - keyWordIndex + 31) % 32];

            }

            AnswerTB.Text = $"Расшифрованное слово >> {decipheredText}";
        }
    }
}
