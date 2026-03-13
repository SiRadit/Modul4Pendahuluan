using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4__103082400027
{
    class KodePos
    {
        public string GetKodePos(string kelurahan)
        {
            string[] dataKelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            string[] dataKodePos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

            for (int i = 0; i < dataKelurahan.Length; i++)
            {
                if (dataKelurahan[i] == kelurahan)
                {
                    return dataKodePos[i];
                }
            }
            return "Kode Pos tidak ditemukan";
        }
    }
}
