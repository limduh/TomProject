using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomBuyTest//물품 재고관리 현황
{
    internal class ProductInfo
    {
        //갯수//총 재고 개수
        public int iKLeftC = 0;   
        public int iWLeftC = 0;   
        public int iELeftC = 0;   
        public int iALeftC = 0;   
        public int iBLeftC = 0;   
        public int iRLeftC = 0;   

        //가격
        public int viKLeftC = 0;  
        public int viWLeftC = 0;  
        public int viELeftC = 0;   
        public int viALeftC = 0;  
        public int viBLeftC = 0;  
        public int viRLeftC = 0;

        //주문 현황
        public int oiKLeftC = 0;
        public int oiWLeftC = 0;
        public int oiELeftC = 0;
        public int oiALeftC = 0;
        public int oiBLeftC = 0;
        public int oiRLeftC = 0;

        public void updateInfo(string databaseInfo)
        {
            iKLeftC = 500;  
            iWLeftC = 100;  
            iELeftC = 50;   
            iALeftC = 30;   
            iBLeftC = 40;   
            iRLeftC = 200;  

            viKLeftC = 2000;
            viWLeftC = 1500;
            viELeftC = 8000;
            viALeftC = 7000;
            viBLeftC = 1000;
            viRLeftC = 2500;

            oiKLeftC = 0;
            oiWLeftC = 0;
            oiELeftC = 0;
            oiALeftC = 0;
            oiBLeftC = 0;
            oiRLeftC = 0;
        }


    }
}
