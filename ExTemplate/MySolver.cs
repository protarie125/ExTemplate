using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemplate
{
    public class MySolver
    {
        // TODO: Data의 형식을 적절하게 바꿉니다.
        public int Data { get; set; }
        // TODO: Result의 형식을 적절하게 바꿉니다.
        public int Result { get; set; }

        public MySolver()
        {
            // TODO: 여기에 인스턴스를 초기화하는 코드를 작성합니다.
            Data = 0;
            Result = 0;
        }

        public void Run()
        {
            // TODO: 여기에 필요한 코드를 작성합니다.
            Result = Data;
        }
    }
}
