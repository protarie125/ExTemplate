using ExTemplate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole
{
    static class MainApp
    {
        static void Main(string[] args)
        {
            var solver = new MySolver();

            // TODO: 여기에 인풋 코드를 작성합니다.
            var input = new FileInfo(@"..\..\input.txt");
            var fs = input.Open(FileMode.Open);
            var sr = new StreamReader(fs);

            for (var i = 0; i < 3; i++)
            {
                solver.Data = int.Parse(sr.ReadLine());

                solver.Run();

                // TODO: 여기에 결과를 콘솔에 출력하기 위한 코드를 작성합니다.
                Console.WriteLine(solver.Result);
            }

            sr.Close();
            fs.Close();

        }
    }
}
