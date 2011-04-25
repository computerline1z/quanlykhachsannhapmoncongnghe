using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncodeByMD5
{
    public class EncodeByMD5
    {
        private static byte[] keyArray;
        protected static byte[] KeyArray
        {
            get { return keyArray; }
            set { keyArray = value; }
        }
        private static byte[] toEndcry;
        protected static byte[] ToEndcry
        {
            get { return toEndcry; }
            set { toEndcry = value; }
        }
        private static string Resualcode;
        public static string ResualCode
        {
            get { return EncodeByMD5.Resualcode; }
            set { EncodeByMD5.Resualcode = value; }
        }
        private static byte[] toEndArray;
        protected static byte[] ToEndArray
        {
            get { return EncodeByMD5.toEndArray; }
            set { EncodeByMD5.toEndArray = value; }
        }
        private static MD5CryptoServiceProvider md5;
        protected static MD5CryptoServiceProvider Md5
        {
            get { return md5; }
            set { md5 = value; }
        }
        private static TripleDESCryptoServiceProvider trip;
        protected static TripleDESCryptoServiceProvider Trip
        {
            get { return trip; }
            set { trip = value; }
        }
        private static ICryptoTransform tranform;
        protected static ICryptoTransform Tranform
        {
            get { return tranform; }
            set { tranform = value; }
        }
        private static byte[] resualArray;
        protected static byte[] ResualArray
        {
            get { return resualArray; }
            set { resualArray = value; }
        }
        public static void Encode(string key, string Encode)
        {
            ToEndcry = UTF8Encoding.UTF8.GetBytes(Encode);
            md5 = new MD5CryptoServiceProvider();
            KeyArray=Md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            trip=new TripleDESCryptoServiceProvider();
            trip.Key=KeyArray;
            trip.Mode=CipherMode.ECB;
            trip.Padding= PaddingMode.PKCS7;
            tranform=trip.CreateEncryptor();
            ResualArray=tranform.TransformFinalBlock(ToEndcry,0,ToEndcry.Length);
            ResualCode=Convert.ToBase64String(ResualArray,0,ResualArray.Length);
        }
        public static void Decode(string key, string Decode)
        {
            ToEndArray = Convert.FromBase64String(Decode);
            md5 = new MD5CryptoServiceProvider();
            KeyArray = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            trip = new TripleDESCryptoServiceProvider();
            trip.Key = KeyArray;
            trip.Mode = CipherMode.ECB;
            trip.Padding = PaddingMode.PKCS7;
            tranform = trip.CreateDecryptor();
            ResualArray = tranform.TransformFinalBlock(ToEndArray, 0, ToEndArray.Length);
            ResualCode = UTF32Encoding.UTF8.GetString(ResualArray);
        }
        public EncodeByMD5()
        {
        }
        ~EncodeByMD5()
        {
        }
    }
}
