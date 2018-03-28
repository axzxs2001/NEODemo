using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace NeoContractDemo001
{
    public class Contract1 : SmartContract
    {
        //public static int Main()
        //{
        //    // Storage.Put(Storage.CurrentContext, "Hello", "World");
        //    //return 1;
        //    ////var arr = Storage.Get(Storage.CurrentContext, "Hello");
        //    ////return arr;
        //}

        public static int Main(int a, int b, int c)
        {
            if (a > b)
                return a * Sum(b, c);
            else
                return Sum(a, b) * c;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
