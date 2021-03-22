using System;

namespace homework3_clock
{
    delegate void TickAction(object sender, TickArgs args);
    delegate void AlarmAction(object sender, AlarmArgs args);
    class TickArgs : EventArgs
    {
        public String Sound;
        public TickArgs(String sound){
            this.Sound = sound;
        }
    }

    class AlarmArgs : EventArgs
    {
        public static String Sound = "Ding,Ding.....";//默认铃声
        public String Todo { get; set; }
        public int Oclock { get; set; }//闹钟默认只能整点报时
        public AlarmArgs(String todo,int time)
        {
            Todo = todo;
            Oclock = time;
        }
    }
    class Clock {
        public event TickAction TickHandler;
        public event AlarmAction AlarmHandler;

        public void Alarm(String todo,int time)
        {
            Console.WriteLine(AlarmArgs.Sound);
            AlarmHandler(this, new AlarmArgs(todo, time));
        }
        public void Tick(String sound)
        {
            TickHandler(this, new TickArgs(sound));
        }
        public Clock()
        {
            Initializer();
        }
        void Initializer()
        {
            this.AlarmHandler += InformTime;
            this.AlarmHandler += InformToDo;
            this.TickHandler += Ticking;
        }
        public void InformTime(object sender, AlarmArgs args)
        {
            Console.WriteLine($"It's {args.Oclock} O'clock now!");
        }
        public void InformToDo(object sender, AlarmArgs args) {
            Console.WriteLine($"Notice! You should {args.Todo} right now!");
        }
        public void Ticking(object sender, TickArgs args)
        {
            Console.WriteLine(args.Sound);
        }
        
    }
    class Program
    {
        static void Main()
        {
            Clock myClock = new Clock();
            myClock.Alarm("DO HOMEWORK", 10);
            Console.WriteLine("=========================");
            myClock.Tick("Tick,Tick...");
        }
    }
}
