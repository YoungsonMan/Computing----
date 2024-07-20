/**************************************************
 * Using 지시문
 * 
 * 소스코드의 상단부에 위치하며 네임스페이스르 선언
 * 선언 이후 소스코드에서 네임스페이스 안의 기능을 사용
 * ***********************************************/

namespace OperatorAssignment
{
    /**********************************************
     * 네임스페이스
     * 폴더링 해놨다. 묶어놨다. 필요할떄만 불러서 쓴다.
     * 기능이나 구분이 비슷한 기능들을 하나의 이름 아래 묶는 기능
     * 수많은 클래스 사용에 혼란이 적도록 용도/분야 별로 정리
     * Java에 Package같은 느낌
     * ***********************************************/
    

    internal class Program
    {
        static void Main(string[] args)
        {

            // Escape Sequence
            Console.WriteLine("나는 \n 경고 \n   '했다' "); // \n 엔터키를/ 줄바꿈을 넣으라고
            Console.WriteLine("나는 \"경고\" 했다 "); // 여기서 "전에 \를 입력해서 ""가 string일 뿐이라는것을 명령.
            Console.WriteLine("나는 \t 경고 \t 했다"); // \t  tab을 넣어달라고
            Console.WriteLine("0 O i l 1 "); // 글꼴에 "consolas 는 숫자0 영어O 이런게 추천폰트 "D2 Coding"


            /********************************************************************
            * Variable 변수
            * 
            * 데이터를 저장하기 위해 프로그램에 의해 이름을 할당받은 메모리 공간
            * 데이터를 저장 할 수 있는 메모리 공간을 의미, 저장된 값은 변경 가능
            * *******************************************************************/
            // <변수 선언 및 초기화>
            // 자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수 선언
            // 선언한 변수에 값을 처음 할당하는 과정을 초기화라고 함
            // 변수 선언과 초기화 과정을 동시에 진행할 수 있음
            
            // 공격력
            int attack = 100; //공격력
            // 100이라는 숫자가 앞으로 자주 사용하게 될 데이터
            int defense = 200; //방어력
            int speed = 30; //속도
            int level = 10; //레벨

            int iValue = 10; // int 자료형의 이름이 iValue인 변수에 10의 
            int iValue2; // int(정수) 자료형의 이름이 iValue2인 변수를 선언함
            iValue2 = 20; // iValue2 변수에 20을 초기화함

            int test = 20;
            Console.WriteLine(test);
            test = 30;
            Console.WriteLine(test + "\n");


            /*********************************************************************
             * 상수
             * 
             * 프로그램이 실행되는 동안 변경할 수 없는 데이터
             * 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있ㅇ르 경우 사용
             * 저장된 값은 프로그램 종료시까지 변경 불가능
             **********************************************************************/
            // <상수 선언 및 초기화4>
            // 변수 선언 앞에 const 키워드를 추가하여 상수 선언

            const int MAXPLAYER = 8; // 상수를 만들때는 all cap 하면 좋음
            // maxPlayer = 12; 이렇게 하려고하면 에러로 안됨
            Console.WriteLine("게임의 최대 플레이어는 {0}입니다.", MAXPLAYER);
            // const int MIN; 상수도 초기화 없이 불가능
            const int MIN = 1;

            /*********************************************************************
            * 자료형 (Data Type)
            * 
            * 자료(데이터)의 형태를 지정
            * 데이터가 메모리에 저자되는 형태와 처리되는 방식을 명시하는 역할
            * 0과 1로만 구성된 컴퓨터에게 여래 형태의 자료를 저장하기 위함.
            **********************************************************************/

            // <자료형 중류>
            // 자료형 이름           자료형 형태          메모리 크기          표현 범위
            //
            // - 논리형 - 
            //  bool                논리자료형             1byte           true / false
            // 
            // - 정수형 - 
            //  short              부호있는 정수형         2byte           -2^15 ~ 2^15 - 1
            //  int                부호있는 정수형         4byte           -2^31 ~ 2^31 - 1
            //  long               부호있는 정수형         8byte           -2^63 ~ 2^63 - 1
            //
            //  ushort, uint, ulong 도 있긴한데 여기선 거의 잘 안씀
            //  ㄴ 위방법으로하면 양수만 표기되어 양수 범위만 2배 로 표현할수 있다.
            //  uint  = 0 ~ 4,294,967,295 (약42억) 4byte
            //
            //  float  (속도)       부동소수점 실수         4byte           3.4e-38 ~ 3.4e+38 => 약
            //  double (정교함)     부동소수점 실수         8byte           1.7e-308 ~ 1.7e+308
            //
            // - 문자형 -
            //  char               유니코드 문자형         2byte             'a', 'b', '한',...
            //  string             유니코드 문자열           X               'abcde", "안녕"
            //
            //
            float ciritical = 0.3f; //소수점 구분을 위해 f를 붙여야함 float소수점이란걸 확고히 하기위해 
            bool active = true;
            // string 불변성






            /**************************************************************************
             * 연산자 과제
             * 최연승
             * 과제1 - 이름 입력받아 출력
             * 과제2 - 두 수의 합 출력
             * 과제3 - 두 수의 합 출력
             **************************************************************************/
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
