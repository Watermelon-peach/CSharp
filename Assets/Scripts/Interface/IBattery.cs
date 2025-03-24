using UnityEngine;
namespace Interface
{
    public interface IBattery
    {
        string GetName();   //메서드 선언하고 구현부 생략, 인터페이스에서는 public
    }

    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }

    public class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }

    public class HdCar
    {
        //필드
        private IBattery battery;

        //생성자
        public HdCar(IBattery _battery)
        {
            this.battery = _battery;
        }


        public void Run()
        {
            Debug.Log($"{battery.GetName()}배터리를 장착한 차가 달린다");
        }
    }
}
