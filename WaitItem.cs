using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class WaitItem
    {
        public int Number { get; set; }          // 대기번호
        public int Room { get; set; }            // 진료실 번호
        public string Dept { get; set; } = "";   // 진료과
        public string Name { get; set; } = "";   // 이름
        public string Birth { get; set; } = "";  // 생년월일
        public string Symptoms { get; set; } = "";
        public DateTime Time { get; set; }       // 접수시간
    }
}
