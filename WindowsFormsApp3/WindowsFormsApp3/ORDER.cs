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
        private int won1500 = 1500, won2000 = 2000, won2500 = 2500;
        // 각 메뉴별 갯수 카운트 (이제 수량이랑 금액 계산때문에 1로 둠)
        private int porkcoun = 1, beefcoun = 1, chickencoun = 1;
        // 각 음료별 주문한 총 금액
        private int porkmny = 0, beefmny = 0, chickenmny = 0;

        // 총 금액, 총 갯수

        public int sumnumber
        {
            get; set;
        }

        public int porkcount
        {
            get { return porkcoun; }
            set { porkcoun = value; }
        }

        public int beefcount
        {
            get { return beefcoun; }
            set { beefcoun = value; }
        }

        public int chickencount
        {
            get { return chickencoun; }
            set { chickencoun = value; }
        }

        // 메뉴들 금액

        public int porksum
        {
            get { return porkmny; }
            set { porkmny = value; }
        }

        public int beefsum
        {
            get { return beefmny; }
            set { beefmny = value; }
        }

        public int chickensum
        {
            get { return chickenmny; }
            set { chickenmny = value; }
        }

        // 메뉴들 총금액을 계산해서 반환해주는 메소드
        public int PorkSum()
        {
            porksum = porkcount * won1500;
            return porksum;
        }

        public int BeefSum()
        {
            beefsum = beefcount * won1500;
            return beefsum;
        }

        public int ChickenSum()
        {
            chickensum = chickencount * won1500;
            return chickensum;
        }

    }

    
}
