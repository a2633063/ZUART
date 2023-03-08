using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUART
{
    public static class Function
    {
        /// <summary>
        /// 字节数组转16进制字符串：空格分隔
        /// </summary>
        /// <param name="byteDatas"></param>
        /// <returns></returns>
        public static string ToHexStrFromByte(byte[] byteDatas)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < byteDatas.Length; i++)
            {
                builder.Append(string.Format("{0:X2} ", byteDatas[i]));
            }
            return builder.ToString().Trim();
        }


        /// <summary>
        /// Byte[]转16进制字符串：空格分隔
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ToByteFromHexStr(string hexString)
        {
            hexString = hexString.Replace(" ", "").Replace("\r", "").Replace("\n", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
    }
}
