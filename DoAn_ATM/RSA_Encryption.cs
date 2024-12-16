using System.Text;
using System.Numerics;
namespace DoAn_ATM
{
    public partial class RSA_Encryption : Form {
        public RSA_Encryption() {
            InitializeComponent();
        }
        public BigInteger d;
        private bool isOKP = false;
        private bool isValidP = false;
        private bool isOKQ = false;
        private bool isValidQ = false;
        private bool isOKE = false;

        // Calculate chunk size base on n = p * q
        private int ChunkSize(BigInteger n) {
            if (n < 127128)
                return 1;

            int i = 0;
            BigInteger sum = 127;

            do {
                i++;
                sum += BigInteger.Pow(1000, i);
            } while (sum < n / 127);
            return i;
        }

        private BigInteger ConvertStringToNumber(string input) {
            string asciiStr = "";
            foreach (char c in input)
                asciiStr += ((int)c).ToString("D3");
            BigInteger res = BigInteger.Parse(asciiStr);
            return res;
        }

        private string ConvertNumberToString(BigInteger input) {
            string decodedStr = input.ToString();
            int numPad = decodedStr.Length % 3 == 0 ? 0 : 3 - decodedStr.Length % 3;
            string paddedStr = decodedStr.PadLeft(decodedStr.Length + numPad, '0');
            string res = "";
            for (int i = 0; i < paddedStr.Length; i += 3) {
                string asciiChunk = paddedStr.Substring(i, 3);
                int asciiValue = int.Parse(asciiChunk);
                res += (char)asciiValue;
            }
            return res;
        }

        private void bt_Encrypt_Click(object sender, EventArgs e) {
            if (isOKP && isOKQ && isOKE)
                rtb_Output.Text = Encrypt(rtb_Input.Text.ToString(), BigInteger.Parse(tb_n.Text), BigInteger.Parse(tb_e.Text));
        }

        public string Decrypt(string encryptedText, BigInteger n, BigInteger d) {
            if (encryptedText == "")
                return "";
            List<string> hexBlocks = new List<string>();
            string tmp = encryptedText.Replace(" ", "");
            int num_bits = RoundNumHexaBit(n);
            for (int i = 0; i < tmp.Length; i += num_bits) {
                hexBlocks.Add(tmp.Substring(i, num_bits));
            }
            string result = "";
            foreach (string hexBlock in hexBlocks) {
                // Chuyển từng cặp hex thành số nguyên
                BigInteger encryptedValue = BigInteger.Parse(hexBlock, System.Globalization.NumberStyles.HexNumber);

                // Giải mã: M = C^d mod n
                BigInteger decryptedValue = BigInteger.ModPow(encryptedValue, d, n);

                // Chuyển giá trị giải mã thành ký tự
                string charBlock = ConvertNumberToString(decryptedValue);
                result += charBlock;
            }
            return result;
        }

        private void bt_Decrypt_Click(object sender, EventArgs e) {
            if (isOKP && isOKQ && isOKE)
                rtb_Output.Text = Decrypt(rtb_Input.Text.ToString(), BigInteger.Parse(tb_n.Text), BigInteger.Parse(d.ToString()));
        }

        private string Encrypt(string text, BigInteger n, BigInteger e) {
            if (text == "")
                return "";
            StringBuilder res = new StringBuilder();
            int numBits = RoundNumHexaBit(n);

            int chunk_size = ChunkSize(n);
            List<string> splitData = new List<string>();
            for (int i = 0; i < text.Length; i += chunk_size) {
                int length = Math.Min(chunk_size, text.Length - i);
                splitData.Add(text.Substring(i, length));
            }

            foreach (string data in splitData) {
                BigInteger charValue = ConvertStringToNumber(data);
                BigInteger encryptedValue = BigInteger.ModPow(charValue, e, n);
                string hexValue = encryptedValue.ToString("X").PadLeft(numBits, '0');
                for (int i = 0; i < hexValue.Length; i += 2) {
                    res.Append(hexValue.Substring(i, Math.Min(2, hexValue.Length - i)).ToUpper());
                    res.Append(" ");
                }
            }

            return res.ToString().TrimEnd();
        }

        private int RoundNumHexaBit(BigInteger n) {
            // Determine the number of bits in n and round to nearest multiple of 4 (hexadecimal alignment)
            int numBits = (int)Math.Ceiling(BigInteger.Log(n, 2));
            int res = numBits + 8 - numBits % 8;
            return res / 4;
        }

        private BigInteger GenerateRandomE(BigInteger phiN) {
            Random rnd = new Random();
            BigInteger e;
            do {
                // Sinh số ngẫu nhiên trong khoảng [2, phiN - 1]
                byte[] buffer = phiN.ToByteArray();
                rnd.NextBytes(buffer);
                buffer[^1] &= 0x7F; // Đảm bảo giá trị không âm
                e = new BigInteger(buffer) % (phiN - 2) + 2; // Giới hạn 2 <= e < phiN
            } while (BigInteger.GreatestCommonDivisor(e, phiN) != 1); // Đảm bảo gcd(e, phiN) = 1
            return e;
        }

        //Tao khoa Public - Private tu gia tri p,q,e da duoc nhap san
        private void bt_KeyPair_Gen_Click(object sender, EventArgs e) {
            if (isOKP && isOKQ && isOKE) {
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
        }

        //Tao ngau nhien toan bo gia tri p,q,e va khoa Public - Private
        private void bt_GenRan_Click(object sender, EventArgs e) {
            BigInteger p = GenerateLargePrime(512); // Sinh số nguyên tố 512 bit
            BigInteger q = GenerateLargePrime(512); // Sinh số nguyên tố 512 bit
            BigInteger n = p * q;
            BigInteger phiN = (p - 1) * (q - 1);
            BigInteger E = GenerateRandomE(phiN);
            d = ModInverse(E, phiN);
            tb_p.Text = p.ToString();
            tb_q.Text = q.ToString();
            tb_e.Text = E.ToString();
            tb_n.Text = n.ToString();
            rtb_PublicKey.Text = "e = " + E.ToString() + "\n" + "n = " + n.ToString();
            rtb_PrivateKey.Text = "d = " + d.ToString() + "\n" + "n = " + n.ToString();
        }
        private BigInteger GenerateLargePrime(int bitLength) {
            Random random = new Random();
            BigInteger primeCandidate;

            do {
                // Sinh số ngẫu nhiên với độ dài bit yêu cầu
                byte[] bytes = new byte[bitLength / 8];
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] |= 0x01; // Đảm bảo số lẻ
                primeCandidate = new BigInteger(bytes);
            } while (!IsProbablePrime(primeCandidate, 10)); // Kiểm tra tính nguyên tố

            return primeCandidate;
        }

        private bool IsProbablePrime(BigInteger number, int certainty) {
            if (number < 2)
                return false;
            if (number != 2 && number % 2 == 0)
                return false;
            if (number == 2 || number == 3 || number == 5 || number == 7)
                return true;

            // Viết số thành dạng 2^s * d
            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0) {
                d /= 2;
                s++;
            }

            // Thực hiện thử nghiệm Miller-Rabin
            for (int i = 0; i < certainty; i++) {
                BigInteger a = RandomBigInt(2, number - 2);
                BigInteger x = BigInteger.ModPow(a, d, number);

                if (x == 1 || x == number - 1)
                    continue;

                bool found = false;
                for (int r = 1; r < s; r++) {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == number - 1) {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    return false;
            }

            return true;
        }

        private BigInteger RandomBigInt(BigInteger minValue, BigInteger maxValue) {
            Random random = new Random();
            byte[] bytes = maxValue.ToByteArray();

            // Đảm bảo rằng giá trị sinh ra nằm trong khoảng minValue đến maxValue
            while (true) {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= 0x7F; // Đảm bảo không có dấu âm

                BigInteger result = new BigInteger(bytes);
                if (result >= minValue && result <= maxValue)
                    return result;
            }
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m) {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            while (a > 1) {
                q = a / m;
                t = m;

                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
                x1 += m0;

            return x1;
        }

        private void tb_p_TextChanged(object sender, EventArgs e) {
            if (tb_p.Text == "") {
                lblAlertP.Text = "ⓘ p is empty!";
                lblAlertP.Visible = true;
                isOKP = false;
                isValidP = false;
            } else {
                BigInteger p;
                bool test = BigInteger.TryParse(tb_p.Text, out p);
                if (!test) {
                    lblAlertP.Text = "ⓘ p must be a prime number! (p > 11)";
                    lblAlertP.Visible = true;
                    isOKP = false;
                    isValidP = false;
                } else {
                    if (!IsProbablePrime(p, 10)) {
                        lblAlertP.Text = "ⓘ p must be a prime number! (p > 11)";
                        lblAlertP.Visible = true;
                        isOKP = false;
                        isValidP = false;
                    } else {
                        if (p < 11) {
                            lblAlertP.Text = "ⓘ p must be a \"large\" number! (p > 11)";
                            lblAlertP.Visible = true;
                            isOKP = false;
                            isValidP = false;
                        } else {
                            lblAlertP.Visible = false;
                            isOKP = true;
                            isValidP = true;
                        }
                    }
                    if (isValidQ) {
                        if (tb_p.Text == tb_q.Text) {
                            lblAlertP.Text = "ⓘ p must be different from q!";
                            lblAlertQ.Text = "ⓘ q must be different from p!";
                            lblAlertP.Visible = true;
                            lblAlertQ.Visible = true;
                            isOKP = false;
                            isOKQ = false;
                        } else {
                            lblAlertQ.Visible = false;
                            isOKQ = true;
                        }
                    }
                }
            }
        }

        private void tb_q_TextChanged(object sender, EventArgs e) {
            if (tb_q.Text == "") {
                lblAlertQ.Text = "ⓘ q is empty!";
                lblAlertQ.Visible = true;
                isOKQ = false;
                isValidQ = false;
            } else {
                BigInteger q;
                bool test = BigInteger.TryParse(tb_q.Text, out q);
                if (!test) {
                    lblAlertQ.Text = "ⓘ q must be a prime number! (q > 11)";
                    lblAlertQ.Visible = true;
                    isOKQ = false;
                    isValidQ = false;
                } else {
                    if (!IsProbablePrime(q, 10)) {
                        lblAlertQ.Text = "ⓘ q must be a prime number! (q > 11)";
                        lblAlertQ.Visible = true;
                        isOKQ = false;
                        isValidQ = false;
                    } else {
                        if (q < 11) {
                            lblAlertQ.Text = "ⓘ q must be a \"large\" number! (q > 11)";
                            lblAlertQ.Visible = true;
                            isOKQ = false;
                            isValidQ = false;
                        } else {
                            lblAlertQ.Visible = false;
                            isOKQ = true;
                            isValidQ = true;
                        }
                    }
                    if (isValidP) {
                        if (tb_p.Text == tb_q.Text) {
                            lblAlertP.Text = "ⓘ p must be different from q!";
                            lblAlertQ.Text = "ⓘ q must be different from p!";
                            lblAlertP.Visible = true;
                            lblAlertQ.Visible = true;
                            isOKP = false;
                            isOKQ = false;
                        } else {
                            lblAlertP.Visible = false;
                            isOKP = true;
                        }
                    }
                }
            }
        }

        private void tb_e_TextChanged(object sender, EventArgs e) {
            if (tb_e.Text == "") {
                lblAlertE.Text = "ⓘ e is empty!";
                lblAlertE.Visible = true;
                isOKE = false;
            } else {
                BigInteger E;
                bool test = BigInteger.TryParse(tb_e.Text, out E);
                if (!test) {
                    lblAlertE.Text = "ⓘ e must be a number! (gcd(e, f(n)) = 1, 1 < e < f(n), f(n) = (p-1)*(q-1)";
                    lblAlertE.Visible = true;
                    isOKE = false;
                } else {
                    if (tb_p.Text != "" && tb_q.Text != "") {
                        BigInteger p, q;
                        bool t1 = BigInteger.TryParse(tb_p.Text, out p);
                        bool t2 = BigInteger.TryParse(tb_q.Text, out q);
                        if (!t1 || !t2) {
                            lblAlertE.Text = "ⓘ p, q is invalid!";
                            lblAlertE.Visible = true;
                            isOKE = false;
                        } else {
                            BigInteger f = (p - 1) * (q - 1);
                            if (BigInteger.GreatestCommonDivisor(E, f) == 1 && E > 1 && E < f) {
                                lblAlertE.Visible = false;
                                isOKE = true;
                            } else {
                                lblAlertE.Text = "ⓘ e is invalid! (gcd(e,f(n))=1, 1<e<f(n), f(n)=(p-1)*(q-1)";
                                lblAlertE.Visible = true;
                                isOKE = false;
                            }
                        }
                    } else {
                        lblAlertE.Text = "ⓘ p, q is empty!";
                        lblAlertE.Visible = true;
                        isOKE = false;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            rtb_Input.Clear();
            rtb_Output.Clear();
            tb_p.Clear();
            tb_q.Clear();
            tb_e.Clear();
            tb_n.Clear();
            rtb_PrivateKey.Clear();
            rtb_PublicKey.Clear();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a text file";
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                rtb_Input.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog {
                Title = "Save File",
                Filter = "Text Files (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true
            };

            if (sfd.ShowDialog() == DialogResult.OK) {
                try {
                    File.WriteAllText(sfd.FileName, rtb_Output.Text);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch {
                    MessageBox.Show("Something is wrong while saving!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
