using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
	public delegate void ClockHandle();
	
	public class time_
	{
		public event ClockHandle alarm_;
		public event ClockHandle run_;
		private int NowTime;
		public void NowCondition(int AlarmTime )
		{
			int second;
			for (second = 0; second <= 60; second++)
			{
				System.Threading.Thread.Sleep(1000);
				Console.Write("the time is " + second+",");
				if (second % AlarmTime == 0)
				{
					alarm_();
;				}
				else
				{
					run_();
				}
			}
		}
	}
	public class form
	{
		public time_ _time = new time_();
		public form()
			{
			_time.alarm_ += new ClockHandle(DoAlarm);
			_time.run_ += new ClockHandle(DoRun);
			}
		public void DoAlarm()
		{
			Console.WriteLine("the clock is alarming");
		}
		public void DoRun()
		{
			Console.WriteLine("the clock is running");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			form form1 = new form();
			form1._time.NowCondition(12);
		}
	}
}
