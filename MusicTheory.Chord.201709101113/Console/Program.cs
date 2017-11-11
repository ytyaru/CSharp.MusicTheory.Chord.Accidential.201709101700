using System;
using System.Collections.Generic;
using System.Linq;//System.Core.dll
using MusicTheory.Chord;
namespace Console
{
	class Program
	{
		public static void Main (string[] args)
		{
			// Accidental.cs
			for (int i = 1; i < 3; i++) {
				foreach (string accidental in new List<string>(){"","+","-","#","b","♯","♭"}) {
					string acc_str = string.Concat(System.Linq.Enumerable.Repeat(accidental, i));
					System.Console.WriteLine (acc_str + ": " + Accidental.GetPitch (acc_str));
					acc_str += "1";
					MusicTheory.Chord.Degree deg = new MusicTheory.Chord.Degree (acc_str);
					System.Console.WriteLine ("度名:" + deg.Name + ", pitch:" + deg.Pitch);
				}
			}
			// Degree.cs
//			MusicTheory.Chord.Degree.Perfects.ForEach (n => System.Console.WriteLine ("P" + n));
//			MusicTheory.Chord.Degree.Majors.ForEach(n => System.Console.WriteLine("M" + n + ", m" + n));
//			foreach (string accidental in new List<string>(){"","+","-","#","b","♯","♭"}) {
//				for (int i = 1; i < 8; i++) {
//					string acc_str = accidental + i;
//					System.Console.WriteLine ("度名:" + acc_str);
//					MusicTheory.Chord.Degree deg = new MusicTheory.Chord.Degree (acc_str);
//					System.Console.WriteLine ("度名:" + deg.Name + ", pitch:" + deg.Pitch);
//				}
//			}
			
//			MusicTheory.Chord.Degree.Perfects.ForEach (n => System.Console.WriteLine ("P" + n));
//			MusicTheory.Chord.Degree.Majors.ForEach(n => System.Console.WriteLine("M" + n + ", m" + n));
//			for (int i = 1; i < 3; i++) {
//				foreach (string accidental in new List<string>(){"","+","-","#","b","♯","♭"}) {
//					for (int d = 1; d < 8; d++) {
//						string acc_str = string.Concat(System.Linq.Enumerable.Repeat(accidental, i)) + d;
//						System.Console.WriteLine ("度名:" + acc_str);
//						MusicTheory.Chord.Degree deg = new MusicTheory.Chord.Degree (acc_str);
//						System.Console.WriteLine ("度名:" + deg.Name + ", pitch:" + deg.Pitch);
//					}
//				}
//			}
		}
	}
}
