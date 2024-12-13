using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAn_ATM
{
    public partial class PlayFair : Form
    {
        private char[,] keyMatrix;
        private bool is5x5Matrix = true; // Default matrix size is 5x5
        public PlayFair()
        {
            InitializeComponent();
        }

        private char[,] CreateMatrix(string key)
        {
            int size = is5x5Matrix ? 5 : 6;
            char[,] matrix = new char[size, size];
            key = new string(key.ToUpper().Where(char.IsLetter).Distinct().ToArray());

            if (is5x5Matrix)
            {
                key = key.Replace("J", "I");
            }

            string alphabet = is5x5Matrix ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string fullKey = key + new string(alphabet.Where(c => !key.Contains(c)).ToArray());

            for (int i = 0, k = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = fullKey[k++];
                }
            }

            UpdateMatrixUI(matrix); 
            return matrix;
        }

        private string FormatText(string text)
        {
            text = new string(text.ToUpper().Where(char.IsLetterOrDigit).ToArray());

            if (is5x5Matrix)
            {
                text = text.Replace("J", "I");
            }

            for (int i = 0; i < text.Length - 1; i += 2)
            {
                if (text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, is5x5Matrix ? "X" : "Z");
                }
            }

            if (text.Length % 2 != 0)
            {
                text += is5x5Matrix ? "X" : "Z";
            }
            return text;
        }

        private string Encrypt(string text)
        {
            return ProcessText(text, true);
        }

        private string Decrypt(string text)
        {
            return ProcessText(text, false);
        }

        private string ProcessText(string text, bool encrypt)
        {
            string result = "";
            int size = is5x5Matrix ? 5 : 6;

            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = text[i + 1];

                int rowA = 0, colA = 0, rowB = 0, colB = 0;
                FindPosition(a, ref rowA, ref colA);
                FindPosition(b, ref rowB, ref colB);

                if (rowA == rowB)
                {
                    colA = (colA + (encrypt ? 1 : -1) + size) % size;
                    colB = (colB + (encrypt ? 1 : -1) + size) % size;
                }
                else if (colA == colB)
                {
                    rowA = (rowA + (encrypt ? 1 : -1) + size) % size;
                    rowB = (rowB + (encrypt ? 1 : -1) + size) % size;
                }
                else
                {
                    int temp = colA;
                    colA = colB;
                    colB = temp;
                }
                result += keyMatrix[rowA, colA].ToString() + keyMatrix[rowB, colB].ToString();
            }
            return result;
        }


        private void FindPosition(char c, ref int row, ref int col)
        {
            int size = is5x5Matrix ? 5 : 6;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (keyMatrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        private void UpdateMatrixUI(char[,] matrix)
        {
            int size = matrix.GetLength(0); // 5x5 hoặc 6x6 tùy chọn

            foreach (Control control in pnlMatrix.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty; // Xóa nội dung cũ
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Lấy TextBox theo tên định dạng txtXY
                    string textBoxName = $"tb{i}{j}";
                    TextBox box = pnlMatrix.Controls[textBoxName] as TextBox;

                    if (box != null)
                    {
                        box.Text = matrix[i, j].ToString(); // Hiển thị ký tự từ ma trận
                    }
                }
            }
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            string text = tbText.Text;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter both text and key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            keyMatrix = CreateMatrix(key);
            string formattedText = FormatText(text);
            tbResult.Text = Encrypt(formattedText);
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            string text = tbText.Text;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter both text and key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            keyMatrix = CreateMatrix(key);
            tbResult.Text = Decrypt(text);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            tbKey.Clear();
            tbResult.Clear();
            ClearMatrix();
        }
        private void bt5x5_Click(object sender, EventArgs e)
        {
            is5x5Matrix = true;
            MessageBox.Show("Matrix size set to 5x5.", "Matrix Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bt6x6_Click(object sender, EventArgs e)
        {
            is5x5Matrix = false;
            MessageBox.Show("Matrix size set to 6x6.", "Matrix Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearMatrix()
        {
            foreach (Control control in pnlMatrix.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
