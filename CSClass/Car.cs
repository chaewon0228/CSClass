using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Car
    {
        /***  <- xml 주석
         * carNumber : 자동차 번호
         ***/
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        /// <summary>
        /// 자동차가 들어온 시간 설정
        /// </summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        /// <summary>
        /// 자동차가 나간 시간 설정
        /// </summary>
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}
