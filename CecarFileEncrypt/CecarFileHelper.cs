using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CecarFileEncrypt
{
    public class CecarFileHelper
    {
        public byte K { get; set; }

        public Byte[] Encrypt(String srcPath)
        {
            byte[] srcBytes = File.ReadAllBytes(srcPath);
            if (srcBytes.Length > 0)
            {
                byte[] desBytes = new byte[srcBytes.Length + 1];
                for (int i = 0; i < srcBytes.Length; i++)
                {
                    int srcByte = srcBytes[i];
                    int desByte = (srcByte + K) % 256;
                    desBytes[i] = (byte)desByte;
                }
                desBytes[desBytes.Length - 1] = K;
                return desBytes;
            }
            else
                return null;
        }

        public Byte[] Decrypt(String desPath)
        {
            byte[] desBytes = File.ReadAllBytes(desPath);
            if (desBytes.Length > 0)
            {
                byte[] srcBytes = new byte[desBytes.Length - 1];
                K = desBytes[desBytes.Length - 1];
                for (int i = 0; i < desBytes.Length - 1; i++)
                {
                    int desByte = desBytes[i];
                    int srcByte = (desByte - K);
                    if (srcByte < 0)
                        srcByte += 256;
                    srcBytes[i] = (byte)srcByte;
                }
                return srcBytes;
            }
            else
                return null;
        }
    }
}
