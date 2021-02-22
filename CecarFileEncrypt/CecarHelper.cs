using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CecarFileEcrypt
{
    public class CecarHelper
    {
        /// <summary>
        /// Hệ số dịch chuyển của thuật toán
        /// </summary>
        public int K { get; set; }

        /// <summary>
        /// Bảng chữ cái để tra cứu mã hóa và giải mã
        /// </summary>
        String[] BangChuCai = new string[]
        {
            "a", "b", "c", "d", "e", "k", "h", "o", "s", "p", "t", "4", "2", "1", "9", "7", "0"
        };

        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="heSoK">Hệ số dịch chuyển</param>
        public CecarHelper(int heSoK)
        {
            K = heSoK;
        }

        /// <summary>
        /// Mã hóa chuỗi ký tự theo thuật toán
        /// </summary>
        /// <param name="duLieuCanMaHoa">Dữ liệu cần mã hóa ở dạng chuỗi</param>
        /// <returns>Chuỗi kết quả sau khi mã hóa</returns>
        public String MaHoa(String duLieuCanMaHoa)
        {
            String ketQua = "";
            for(int i = 0; i < duLieuCanMaHoa.Length; i++)
            {
                int viTri = -1;
                for(int j = 0; j < BangChuCai.Length; j++)
                {
                    if(BangChuCai[j].Equals(duLieuCanMaHoa[i].ToString()))
                    {
                        viTri = j;
                        break;
                    }    
                }
                if (viTri == -1)
                    ketQua += duLieuCanMaHoa[i];
                else
                {
                    int viTriMoi = (viTri + K) % BangChuCai.Length;
                    ketQua += BangChuCai[viTriMoi];
                }    
            }
            return ketQua;
        }

        /// <summary>
        /// Giải mã dữ liệu đã được mã hóa
        /// </summary>
        /// <param name="duLieuCanGiaiMa">Dữ liệu đã mã hóa cần giải mã</param>
        /// <returns>Dữ liệu đã được giải mã</returns>
        public String GiaiMa(String duLieuCanGiaiMa)
        {
            String ketQua = "";
            for (int i = 0; i < duLieuCanGiaiMa.Length; i++)
            {
                int viTri = -1;
                for (int j = 0; j < BangChuCai.Length; j++)
                {
                    if (BangChuCai[j].Equals(duLieuCanGiaiMa[i].ToString()))
                    {
                        viTri = j;
                        break;
                    }
                }
                if (viTri == -1)
                    ketQua += duLieuCanGiaiMa[i];
                else
                {
                    int viTriMoi = viTri - K;
                    if (viTriMoi < 0)
                        viTriMoi = viTriMoi + BangChuCai.Length;
                    ketQua += BangChuCai[viTriMoi];
                }
            }
            return ketQua;
        }
    }
}
