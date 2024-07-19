namespace OperatorAssignment
{
    /**************************************************************************
     * 연산자 과제
     * 최연승
     * 과제1 - 이름 입력받아 출력
     * 과제2 - 두 수의 합 출력
     * 과제3 - 두 수의 합 출력
     **************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제1
            // 과제 1. 이름 받아 출력 
            // 이름을 받아, 반갑다고 출력하기
            Console.WriteLine("당신의 이름을 입력해주세요");
            string intput = Console.ReadLine();
            Console.WriteLine($"{intput}님, 반갑습니다. \n \n ");
            #endregion

            #region 과제2
            // 과제 2. 두 수의 합 출력
            // 두 실수를 유저로부터 한줄씩 입력받아, 마지막 줄엔 둘의 합을 출력.
            Console.WriteLine("첫번째 실수를 입력해 주세요");
            string inputNum1 = Console.ReadLine();
            int intNum1 = int.Parse(inputNum1);
            Console.WriteLine("두번째 실수를 입력해 주세요");
            string inputNum2 = Console.ReadLine();
            int intNum2 = int.Parse(inputNum2);
            int answer = intNum1 + intNum2;
            Console.WriteLine("두 수의 합은 {0} \n \n", answer);
            #endregion

            #region 과제3
            // 과제 3. 두 정수의 몫과 나머지 출력
            // 두 정수를 유저로부터 입력 받고, 몫과 나머지를 출력해보자.
            Console.WriteLine("나눗셈을 진행할 첫번째 정수를 입력하여 주세요");
            string inputNum3 = Console.ReadLine();
            int intNum3 = int.Parse(inputNum3);
            Console.WriteLine("나눗셈을 진행할 두번째 정수를 입력하여 주세요");
            string inputNum4 = Console.ReadLine();
            int intNum4 = int.Parse(inputNum4);
            int answer2 = intNum3 / intNum4;
            int remainder = intNum3 % intNum4;
            Console.WriteLine($"{intNum3}와 {inputNum4}의 나눗셈 결과, 몫은 {answer2} 나머지 {remainder} \n \n");
            #endregion

            #region 과제4
            // 과제 4. 입력된 세 정수의 합 & 곱 출력
            // 세 정수를 유저로부터 입력받고, 앞 두수를 더하고 세번째수는 곱하기.
            // "첫째수 더하기 둘째수에 셋째수를 곱한 값은 X 입니다" 라고 출력.
            Console.WriteLine("첫번째 정수 입력");
            string inputNum5 = Console.ReadLine();
            int intNum5 = int.Parse(inputNum5);
            Console.WriteLine("두번째 정수 입력");
            string inputNum6 = Console.ReadLine();
            int intNum6 = int.Parse(inputNum6);
            Console.WriteLine("세번째 정수 입력");
            string inputNum7 = Console.ReadLine();
            int intNum7 = int.Parse(inputNum7);

            int answer3 = (intNum5 + intNum6) * intNum7;
            Console.WriteLine("첫째수 더하기 둘째수에 셋째수를 곱한 값은 {0} 입니다.", answer3);
            #endregion
        }
    }
}
