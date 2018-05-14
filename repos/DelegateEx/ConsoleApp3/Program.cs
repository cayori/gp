﻿using System;

namespace ConsoleApp3
{
    class CallbackArg { } // 콜백의 값을 담는 클래스의 최상위 부모 클래스 역할

    class PrimeCallbackArg : CallbackArg
    {
        public int prime;

        public PrimeCallbackArg(int prime)
        {
            this.prime = prime;
        }
    }

    // 소수 생성기: 소수가 발생할 떄마다 등록된 콜백 메서드를 호출
    class PrimeGenerator
    {
        // 콜백을 위한 델리게이트 타입 정의
        public delegate void PrimeDelegate(object sender, CallbackArg arg);
        // 콜백 메서드를 보관하는 델리게이트 인스턴스 필드
        PrimeDelegate callbacks;

        // 콜백 메서드를 추가
        public void AddDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
        }

        // 콜백 메서드를 삭제
        public void RemoveDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
        }

        // 주어진 수까지 루프를 돌면서 소수가 발견되면 콜백 메서드 호출
        public void Run(int limit)
        {
            for(int i=2; i<= limit; i++)
            {
                if(IsPrime(i) == true && callbacks != null)
                {
                    // 콜백을 발생시킨 측의 인스턴스와 발견된 소수를 콜백 메서드에 전달
                    callbacks(this, new PrimeCallbackArg(i));
                }
            }
        }

        // 소수 판정 메서드.
        public bool IsPrime(int candidate)
        {
            for(int i=2; i<candidate; i++)
            {
                if(candidate%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        // 콜백으로 등록될 메서드 1
        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).prime + ", ");
        }

        static int sum;

        // 콜백으로 등록될 메서드 2
        static void SumPrime(object sender, CallbackArg arg)
        {
            sum += (arg as PrimeCallbackArg).prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            // PrintPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callprint = PrintPrime;
            gen.AddDelegate(callprint);

            // sumPrime 콜백 메서드 추가
            PrimeGenerator.PrimeDelegate callsum = SumPrime;
            gen.AddDelegate(callsum);

            // 1~10 까지의 소수를 구하고, 
            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(sum);

            // sumPrime 콜백 메서드를 제거한 후 다시 1~15까지 소수를 구하는 메서드 호출
            gen.RemoveDelegate(callsum);
            gen.Run(15);
        }
    }
}
