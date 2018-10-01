using System;
using System.Collections;
using System.Collections.Generic;

namespace ShoppingCartByHashTable
{

    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가=" + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            //여기를 채우세요....       

            ArrayList ct = new ArrayList();
            ct.Add(new Goods(1001, "볼펜", 2000));
            ct.Add(new Goods(1002, "연필", 500));
            ct.Add(new Goods(1003, "딸기", 6000));

        }
    }
    /*
        1. 미니 쇼핑카트를 구현하세요.

        장바구니의 구조가 다음과 같다. 

        CartNo 상품코드  상품명  단가     수량    합계금액 
        ------------------------------------------------------------- 
        1      1001      볼펜    1000      2      2000 
        2      1002      연필    500       3      1500 
        3      1003      딸기    6000      2      12000 

        [결과]
        1 : 1001 : 볼펜: 2000 : 2 : 4000
        2 : 1002 : 연필: 500  : 3 : 1500
        3 : 1003 : 딸기: 6000 : 2 : 12000
*/
}