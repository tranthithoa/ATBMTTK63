using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonBang
{
    public class DonBangHelper
    {
        char[] bangChuCai = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'r', 'u', 'o', 's', 'p' };
        char[] khoa;

        public DonBangHelper()
        {
            khoa = new char[bangChuCai.Length];
            List<char> ds = bangChuCai.ToList();
            Random rd = new Random();
            int dem = 0;
            while(ds.Count > 0)
            {
                int viTri = rd.Next(0, ds.Count - 1);
                khoa[dem] = ds[viTri];
                dem++;
                ds.RemoveAt(viTri);
            }    
        }

        public String MaHoa(String giaTriCanMaHoa)
        {
            String ketQuaMaHoa = "";
            for(int i = 0; i < giaTriCanMaHoa.Length; i++)
            {
                char kyTuCanMa = giaTriCanMaHoa[i];                
                int viTriBCC = -1;
                for(int j = 0; j < bangChuCai.Length; j++)
                {
                    if(bangChuCai[j].ToString().Equals(kyTuCanMa.ToString()))
                    {
                        viTriBCC = j;
                        break;
                    }    
                }
                if (viTriBCC == -1)
                    ketQuaMaHoa += kyTuCanMa;
                else
                    ketQuaMaHoa += khoa[viTriBCC];
            }
            return ketQuaMaHoa;
        }

        public String GiaiMa(String giaTriCanGiaiMa)
        {
            String ketQuaGiaiMa = "";
            for (int i = 0; i < giaTriCanGiaiMa.Length; i++)
            {
                char kyTuCanGiaiMa = giaTriCanGiaiMa[i];
                int viTriBCC = -1;
                for (int j = 0; j < khoa.Length; j++)
                {
                    if (khoa[j].ToString().Equals(kyTuCanGiaiMa.ToString()))
                    {
                        viTriBCC = j;
                        break;
                    }
                }
                if (viTriBCC == -1)
                    ketQuaGiaiMa += kyTuCanGiaiMa;
                else
                    ketQuaGiaiMa += bangChuCai[viTriBCC];
            }
            return ketQuaGiaiMa;
        }


    }
}
