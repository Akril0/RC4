using System.Text;

namespace RC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cipher_Click(object sender, EventArgs e)
        {
            char[] byteKey = Key.Text.ToCharArray();

            RC4Cipher encoder = new RC4Cipher(byteKey);
            char[] inputData = input.Text.ToCharArray();
            char[] result = encoder.Encode(inputData, inputData.Length);
            output.Text= CharArrToString(result);


        }
        public string CharArrToString(char[] arr)
        {
            string res = "";
            for(int i=0; i<arr.Length; i++)
            {
                res+= (char)arr[i];
            }
            return res;
        }
    }
}