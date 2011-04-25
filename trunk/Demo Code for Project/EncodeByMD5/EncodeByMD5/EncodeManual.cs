using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodeByMD5
{
    public class EncodeManual
    {
        private string key;
        private string strencode;
        private int numberOfHDD;
        private string strDecode;
        public string StrDecode
        {
            get { return strDecode; }
            set { strDecode = value; }
        }

        public int NumberOfHDD
        {
            get { return numberOfHDD; }
            set { numberOfHDD = value; }
        }
        public string Strencode
        {
            get { return strencode; }
            set { strencode = value; }
        }
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string Resual;

        public string ReSual
        {
            get { return Resual; }
            set { Resual = value; }
        }
        private string hdd;

        public string HDD
        {
            get { return hdd; }
            set { hdd = value; }
        }

        public void EnCode()
        {
           //buoc 1: dung thuat toan MD5
            EncodeByMD5.Encode(Key, Strencode);
            //duoc 2 :dung thuat toan ASE
            EncodeByAes ase = new EncodeByAes(KeySize.Bits256, new byte[16]);
            byte[] cipherText = new byte[16]; 
            ase.Cipher(GetByte(EncodeByMD5.ResualCode),cipherText);
            string s = Encoding.ASCII.GetString(cipherText);
            //buoc 3: them thong tin phan cung
            GetHDD();
            ReSual = s + HDD+NumberOfHDD.ToString();
        }
        private byte[] GetByte(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
        private void GetHDD()
        {
            InfoSystem i = new InfoSystem();
            string drive = "C";
            HDD = i.GetHDDSerialNumber(drive);
            NumberOfHDD = HDD.Length;
        }
        public void DecodeConfig()
        {
            EncodeByMD5.Decode(Key, StrDecode);
        }
        public void EncodeConfig()
        {
            EncodeByMD5.Encode(Key, Strencode);
        }
    }
}
