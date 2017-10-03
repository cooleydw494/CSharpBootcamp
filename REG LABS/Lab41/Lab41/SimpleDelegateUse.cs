using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41
{
    delegate void StringProcessor(string input);

    class SimpleDelegateUse
    {
        private static StringProcessor processor;

        static void Main(string[] args)
        {
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");

            StringProcessor jonsVoice = new StringProcessor(jon.Say);
            StringProcessor tomsVoice = new StringProcessor(tom.Say);
            StringProcessor background = new StringProcessor(BackGround.Note);

            processor += jon.Say;
            processor += tom.Say;
            processor += BackGround.Note;

        }
    }
}
