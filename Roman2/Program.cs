using System;

namespace Roman2
{
    class Program
    {
        static string[] dictionaryX={"","I","II","III","IV","V","VI","VII","VIII","IX"};
        static string[] dictionaryC={"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
        static string[] dictionaryM={"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
        static string[] dictionaryMMM={"","M","MM","MMM"};



        static string[][] dictionary={dictionaryX,dictionaryC,dictionaryM,dictionaryMMM};
        static void Main(string[] args)
        {
           Console.WriteLine(ConvertRoman(2022));
        }
        public static string ConvertRoman(int num){
            int divider=1000;
            string temp="";
            for(int i=3;i>=0;i--){

                temp+=dictionary[i][num/divider];
                num%=divider;
                divider/=10;
            }
            return temp;
        }

    }
    


}



