using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GenericClass
{
    //고객을 관리하는 클래스
    public class Person
    {
        public string Name { get; set; }
    }
    public class CollectionInitializers : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //고객 전용 리스트
            List<Person> people = new List<Person>()
            {
                new Person {Name = "뿡길똥"},
                new Person {Name = "똥방구"},
                new Person {Name = "뿡부직"}
            };

            foreach (var p in people)
            {
                Debug.Log(p.Name);
            }
        }
    }

}
