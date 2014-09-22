//If the flow task is A->B->(C||D)->E->F,
//then the graph in my opinion could be realized as like this:
// A->B->C->E->F
//       D->



using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace dhw1
{
	public class func
    
 {
	char[] i=new char[20];
	char[] p=new char[20];
	int k=3;	
	int q=0;

	public  void
		slp0 (char a, int m)   // The first beginning task
	{
		System.Threading.Thread.Sleep (m);
		
		i[0]=a;
		i[1]='-';
		i[2]='>';

	}

	public void
		slp1 (char b, int m, char c)   // The one-parent one-son task
	{
			System.Threading.Thread.Sleep (m);

		i [k] = b;
		i[k+1]='-';
		i[k+2]='>';
		k = k + 3;
	}

	public void
		slp2 (char a, char b, int m, int n, char c)   // The two-son tasks
		{
			System.Threading.Thread.Sleep (m);
			System.Threading.Thread.Sleep (n);
			q = k;

			i [k] = a;
			i[k+1]='-';
			i[k+2]='>';

			p [q] = b;
			p[q+1]='-';
			p[q+2]='>';

			k = k + 3;
		}

		public void
		slp3 (char a, int m, char b, char c)   // The two-parent one-son task
		{
			System.Threading.Thread.Sleep (m);

			i [k] = a;
			i[k+1]='-';
			i[k+2]='>';

			k = k + 3;
		}

		public void
		slp4 (char a, int m, char b)   // The final task
		{
			System.Threading.Thread.Sleep (m);

			i [k] = a;
		}
	// ----------------------------


	public static void Main(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //program time used
			sw.Start();

			slp0 ('A', 1000);
			slp1 ('B', 1000, 'A');
			slp2 ('C', 'D', 1000, 'B');
			slp3 ('E', 1000, 'C', 'D');
			slp4 ('F', 1000, 'E');
		    System.Console.WriteLine(i);
			System.Console.WriteLine(p);

			sw.Stop();
			Console.WriteLine(string.Format("{0}.{1}"), sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);
	}
}
}

