using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class ORDER
    {
        // 각 메뉴 하나당 곱해야할 가격 종류
        private int won1500 = 1500, won2000 = 2000, won2500 = 2500, won4500 = 4500;
        // 각 메뉴별 갯수 카운트 (이제 수량이랑 금액 계산때문에 1로 둠)
        private int chamcoun = 1, freshcoun = 1, startcoun = 1 ,noncoun = 1, jinrocoun =1;
        // 각 음료별 주문한 총 금액
        private int chammny = 0, freshmny = 0, startmny = 0, nonmny = 0, jinromny=0; 

        // 총 금액, 총 갯수

        public int sumnumber
        {
            get; set;
        }
        public int sumcash
        {
            get; set;
        }

        public int noncount 
        {
            get { return noncoun; }
            set { noncoun = value; }
        }

        public int chamcount
        {
            get { return chamcoun; }
            set { chamcoun = value; }
        }

        public int freshcount
        {
            get { return freshcoun; }
            set { freshcoun = value; }
        }

        public int startcount
        {
            get { return startcoun; }
            set { startcoun = value; }
        }

        public int jinrocount
        {
            get { return jinrocoun; }
            set { jinrocoun = value; }
        }



        // 메뉴들 금액

        public int nonsum  
        {
            get { return nonmny; }
            set { nonmny = value; }
        }

        public int chamsum
        {
            get { return chammny; }
            set { chammny = value; }
        }

        public int freshsum
        {
            get { return freshmny; }
            set { freshmny = value; }
        }

        public int startsum
        {
            get { return startmny; }
            set { startmny = value; }
        }
        public int jinrosum
        {
            get { return jinromny; }
            set { jinromny = value; }
        }

        // 메뉴들 총금액을 계산해서 반환해주는 메소드
        public int NonSum()
        {
            nonsum = noncount * won4500;
            return nonsum;
        }

        public int ChamSum()
        {
            chamsum = chamcount * won4500;
            return chamsum;
        }

        public int FreshSum()
        {
            freshsum = freshcount * won4500;
            return freshsum;
        }

        public int StartSum()
        {
            startsum = startcount * won4500;
            return startsum;
        }
        public int JinroSum()
        {
            jinrosum = jinrocount * won4500;
            return jinrosum;
        }


        public int SumCash() // 총 금액
        {
            sumcash = chamsum + freshsum + startsum + jinrosum;
            return sumcash;
        }
    }

    
}
