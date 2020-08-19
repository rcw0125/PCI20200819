using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class Base2e15
    {
        // Methods
        public static byte[] Decode(string input)
        {
            int num = 8;
            int num2 = 0;
            char[] chArray = input.ToCharArray();
            int length = chArray.Length;
            int num4 = ((length * 15) + 7) / 8;
            byte[] buffer = new byte[num4];
            int num5 = 0;
            for (int i = 0; i < length; i++)
            {
                char ch = chArray[i];
                if ((ch > '㏿') && (ch < 0xd7a4))
                {
                    int num6;
                    if (ch > 0xabff)
                    {
                        num6 = ch - '垤';
                    }
                    else
                    {
                        if (ch > 0x8925)
                        {
                            continue;
                        }
                        if (ch > '䷿')
                        {
                            num6 = ch - '㓊';
                        }
                        else
                        {
                            if (ch > '䶵')
                            {
                                continue;
                            }
                            if (ch > '㑿')
                            {
                                num6 = ch - '㒀';
                            }
                            else
                            {
                                num6 = ch - '㐀';
                                buffer[num5++] = (byte)((num2 << num) | (num6 >> (7 - num)));
                                break;
                            }
                        }
                    }
                    buffer[num5++] = (byte)((num2 << num) | (num6 >> (15 - num)));
                    num2 = num6;
                    num -= 7;
                    if (num < 1)
                    {
                        buffer[num5++] = (byte)(num2 >> -num);
                        num += 8;
                    }
                }
            }
            byte[] buffer2 = new byte[num5];
            for (int j = 0; j < num5; j++)
            {
                buffer2[j] = buffer[j];
            }
            return buffer2;
        }

        public static string Encode(byte[] byts)
        {
            int num = 15;
            int num2 = 0;
            int num3 = ((byts.Length * 8) + 14) / 15;
            char[] chArray = new char[num3];
            int num4 = 0;
            for (int i = 0; i < byts.Length; i++)
            {
                byte num6 = byts[i];
                if (num > 8)
                {
                    num2 = (num2 << 8) | num6;
                    num -= 8;
                }
                else
                {
                    num2 = ((num2 << num) | (num6 >> (8 - num))) & 0x7fff;
                    if (num2 < 0x1936)
                    {
                        chArray[num4++] = (char)(num2 + 0x3480);
                    }
                    else if (num2 < 0x545c)
                    {
                        chArray[num4++] = (char)(num2 + 0x34ca);
                    }
                    else
                    {
                        chArray[num4++] = (char)(num2 + 0x57a4);
                    }
                    num2 = num6;
                    num += 7;
                }
            }
            if (num != 15)
            {
                if (num > 7)
                {
                    chArray[num4++] = (char)(((num2 << (num - 8)) & 0x7f) + 0x3400);
                }
                else
                {
                    num2 = (num2 << num) & 0x7fff;
                    if (num2 < 0x1936)
                    {
                        chArray[num4++] = (char)(num2 + 0x3480);
                    }
                    else if (num2 < 0x545c)
                    {
                        chArray[num4++] = (char)(num2 + 0x34ca);
                    }
                    else
                    {
                        chArray[num4++] = (char)(num2 + 0x57a4);
                    }
                }
            }
            return new string(chArray);
        }
    }
}
