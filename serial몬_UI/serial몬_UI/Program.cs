using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace serial몬_UI
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() // 메인함수 넣는 곳
        {

            Person girlEmpty;
            Person girl = new Person(26, "서영", GENDER_TYPE.GENDER_FEMAIL); // new 변수 지정시 필요           


            girl.AddAge();
            girl.ChangeName("김서서서영");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }




    public enum GENDER_TYPE    
    {
        GENDER_MAIL,
        GENDER_FEMAIL
    };



    
    public class Person // person이라는 클래스(객체)
                        // 함수 선언을 해서 일일히 다 main에서 바꾸는 것 방지 
    {
        // 3가지 속성가지고 있는 것
        private int age;
        private string name;
        private GENDER_TYPE gender;

        private Person() // 아무것도 없는 것 방지하기 위해 한 번 더 선언 (생성자와 같은 이름)
                         // 객체는 생성 될적에 고유한 속성이 전부 정의 되어 있어야한다. ---> public person
        {

        }
        public Person(int age, string name, GENDER_TYPE gender) // 생성자가 총 2개 private Person(), public Person

        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        // 총 3개의 함수 선언
        public void AddAge()
        {
            // this를 사용하면 똑같은 이름이라도 앞에 것을 가르킨다.
            // this = person, age는 앞에 age
            // void는 반환이 안됨 그래서 return이 없음
            this.age = this.age * 2;
        }
        public void ChangeName(string name) // 이름 3글자 초과하면 에러
        {
            if (name.Length > 3)
            {
                Console.WriteLine("이름길이 초과");
            }
            else this.name = name;
        }
        public void ChangeGender(GENDER_TYPE gender) // 앞에서GENDER_TYPE 미리 정의
        {
            this.gender = gender;
        }
    }
}
