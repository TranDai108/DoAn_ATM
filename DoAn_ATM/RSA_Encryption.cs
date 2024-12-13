﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Security.Cryptography;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
namespace DoAn_ATM
{
    public partial class RSA_Encryption : Form
    {
        public RSA_Encryption()
        {
            InitializeComponent();
        }
        public BigInteger d;
        
        private void bt_Encrypt_Click(object sender, EventArgs e)
        {
            rtb_Output.Text = Encrypt(rtb_Input.Text.ToString(), BigInteger.Parse(tb_n.Text), BigInteger.Parse(tb_e.Text));
        }

        public static string Decrypt(string encryptedText, BigInteger n, BigInteger d)
        {
            List<string> hexPairs = new List<string>(); 
            string tmp = encryptedText.Replace(" ", "");
            int num_bits = RoundNumHexaBit(n);
            MessageBox.Show(num_bits.ToString());
            for (int i = 0; i < tmp.Length; i += num_bits) {
                hexPairs.Add(tmp.Substring(i, num_bits));
            }
            string result = "";
            foreach (string hexPair in hexPairs)
            {
                // Chuyển từng cặp hex thành số nguyên
                BigInteger encryptedValue = BigInteger.Parse(hexPair, System.Globalization.NumberStyles.HexNumber);

                // Giải mã: M = C^d mod n
                BigInteger decryptedValue = BigInteger.ModPow(encryptedValue, d, n);

                // Chuyển giá trị giải mã thành ký tự
                char originalChar = (char)(int)decryptedValue;
                result += originalChar;
            }
            return result;
        }

        private void bt_Decrypt_Click(object sender, EventArgs e)
        {
            rtb_Output.Text = Decrypt(rtb_Input.Text.ToString(), BigInteger.Parse(tb_n.Text), BigInteger.Parse(d.ToString()));
        }

        static string Encrypt(string text, BigInteger n, BigInteger e)
        {
            StringBuilder res = new StringBuilder();
            int numBits = RoundNumHexaBit(n);

            foreach (char c in text)
            {
                // Convert character to ASCII, encrypt, and convert to hexadecimal
                BigInteger charValue = new BigInteger(Encoding.ASCII.GetBytes(c.ToString())[0]);
                BigInteger encryptedValue = BigInteger.ModPow(charValue, e, n);
                string hexValue = encryptedValue.ToString("X").PadLeft(numBits, '0'); // Convert to hex and pad

                // Split into pairs
                for (int i = 0; i < hexValue.Length; i += 2)
                {
                    res.Append(hexValue.Substring(i, Math.Min(2, hexValue.Length - i)).ToUpper());
                    res.Append(" ");
                }
            }

            return res.ToString().TrimEnd();
        }

        static int RoundNumHexaBit(BigInteger n)
        {
            // Determine the number of bits in n and round to nearest multiple of 4 (hexadecimal alignment)
            int numBits = (int)Math.Ceiling(Math.Ceiling(BigInteger.Log(n, 2)) / 4);
            if (numBits % 2 != 0)
                return numBits + 1;
            return numBits;
        }

        private BigInteger GenerateRandomE(BigInteger phiN)
        {
            Random rnd = new Random();
            BigInteger e;
            do
            {
                // Sinh số ngẫu nhiên trong khoảng [2, phiN - 1]
                byte[] buffer = phiN.ToByteArray();
                rnd.NextBytes(buffer);
                buffer[^1] &= 0x7F; // Đảm bảo giá trị không âm
                e = new BigInteger(buffer) % (phiN - 2) + 2; // Giới hạn 2 <= e < phiN
            } while (BigInteger.GreatestCommonDivisor(e, phiN) != 1); // Đảm bảo gcd(e, phiN) = 1
            return e;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Tao khoa Public - Private tu gia tri p,q,e da duoc nhap san
        private void bt_KeyPair_Gen_Click(object sender, EventArgs e)
        {
            BigInteger p = BigInteger.Parse(tb_p.Text);
            BigInteger q = BigInteger.Parse(tb_q.Text);
            BigInteger E = BigInteger.Parse(tb_e.Text);
            BigInteger n = p * q;
            BigInteger phiN = (p - 1) * (q - 1);
            d = ModInverse(E, phiN);
            tb_n.Text = n.ToString();
            rtb_PublicKey.Text = "e = " + E.ToString() + "\n" + "n = " + n.ToString();
            rtb_PrivateKey.Text = "d = " + d.ToString() + "\n" + "n = " + n.ToString();
        }        
        //Tao ngau nhien toan bo gia tri p,q,e va khoa Public - Private
        private void bt_GenRan_Click(object sender, EventArgs e)
        {
            BigInteger p = GenerateLargePrime(512); // Sinh số nguyên tố 512 bit
            BigInteger q = GenerateLargePrime(512); // Sinh số nguyên tố 512 bit
            BigInteger n = p * q;
            BigInteger phiN = (p - 1) * (q - 1);
            BigInteger E = GenerateRandomE(phiN);
            BigInteger d = ModInverse(E, phiN);
            tb_p.Text = p.ToString();
            tb_q.Text = q.ToString();
            tb_e.Text = E.ToString();
            tb_n.Text = n.ToString();
            rtb_PublicKey.Text = "e = " + E.ToString() + "\n" + "n = " + n.ToString();
            rtb_PrivateKey.Text = "d = " + d.ToString() + "\n" + "n = " + n.ToString();
            /*using (var rsa = RSA.Create())
            {
                rsa.KeySize = 1024; // Đặt kích thước khóa (bit)

                // Xuất tham số RSA
                var parameters = rsa.ExportParameters(true);
                tb_p.Text = new BigInteger(parameters.P).ToString();
                tb_q.Text = new BigInteger(parameters.Q).ToString();
                tb_e.Text = new BigInteger(parameters.Exponent).ToString();
                Console.WriteLine("d: " + Convert.ToBase64String(parameters.D));
                Console.WriteLine("n: " + Convert.ToBase64String(parameters.Modulus));
            }*/
        }
        static BigInteger GenerateLargePrime(int bitLength)
        {
            Random random = new Random();
            BigInteger primeCandidate;

            do
            {
                // Sinh số ngẫu nhiên với độ dài bit yêu cầu
                byte[] bytes = new byte[bitLength / 8];
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] |= 0x01; // Đảm bảo số lẻ
                primeCandidate = new BigInteger(bytes);
            } while (!IsProbablePrime(primeCandidate, 10)); // Kiểm tra tính nguyên tố

            return primeCandidate;
        }

        static bool IsProbablePrime(BigInteger number, int certainty)
        {
            if (number < 2) return false;
            if (number != 2 && number % 2 == 0) return false;

            // Viết số thành dạng 2^s * d
            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            // Thực hiện thử nghiệm Miller-Rabin
            for (int i = 0; i < certainty; i++)
            {
                BigInteger a = RandomBigInt(2, number - 2);
                BigInteger x = BigInteger.ModPow(a, d, number);

                if (x == 1 || x == number - 1)
                    continue;

                bool found = false;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == number - 1)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) return false;
            }

            return true;
        }

        static BigInteger RandomBigInt(BigInteger minValue, BigInteger maxValue)
        {
            Random random = new Random();
            byte[] bytes = maxValue.ToByteArray();

            // Đảm bảo rằng giá trị sinh ra nằm trong khoảng minValue đến maxValue
            while (true)
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= 0x7F; // Đảm bảo không có dấu âm

                BigInteger result = new BigInteger(bytes);
                if (result >= minValue && result <= maxValue)
                    return result;
            }
        }

        static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;

                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;

            return x1;
        }

    }
}
