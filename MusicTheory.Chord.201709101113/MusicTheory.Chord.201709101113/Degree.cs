using System;
using System.Collections.Generic;
namespace MusicTheory.Chord
{
	/// <summary>音度.</summary>
	public class Degree
	{
		/// <summary>完全系</summary>
		public static readonly List<int> Perfects = new List<int> () {1, 4, 5};
		/// <summary>長短系</summary>
		public static readonly List<int> Majors = new List<int> () {2, 3, 6, 7};
		/// <summary>完全、長短系のピッチクラス</summary>
		public static readonly Dictionary<int, int> Pitchs = new Dictionary<int, int>()
		{{1, 0},{2, 2},{3, 4},{4, 5},{5, 7},{6, 9},{7, 11}};
		/// <summary>音度名</summary>
		public string Name { get; private set; }
		/// <summary>ピッチクラス</summary>
		public int Pitch { get; private set; }
		/// <summary>音度名からPitchClassを算出する。</summary>
		/// <param name="degree">Degree.</param>
		public Degree(string name)
		{
			this.SetPitch(name);
		}

		private void SetPitch(string name) {
			// [変化記号]?[音度]
			// 1,-2,+3,--4
			// [+|-]*[1-9][0-9]?

			// 定数から正規表現パターン文字列を作成する（と思ったが、-だけ\を付与せねばならないため面倒。断念。）
//			string acc_chr = @"";
//			//			foreach (char c in new char[]{Accidental.Flat.Unicode, Accidental.Flat.Ascii, Accidental.Flat.Operator, Accidental.Sharp.Unicode, Accidental.Sharp.Ascii, Accidental.Sharp.Operator}){acc_chr += c + '|';}
////			foreach (char c in new char[]{Accidental.Flat.Unicode, Accidental.Flat.Ascii, Accidental.Flat.Operator, Accidental.Sharp.Unicode, Accidental.Sharp.Ascii, Accidental.Sharp.Operator}){acc_chr += c + "|";}
//			foreach (char c in new char[]{Accidental.Sharp.Operator, Accidental.Flat.Operator, Accidental.Sharp.Ascii, Accidental.Flat.Ascii, Accidental.Sharp.Unicode, Accidental.Flat.Unicode}){acc_chr += @"" + @c + @"|";}
//			acc_chr = @acc_chr.Substring (0, acc_chr.Length - 1);
//			System.Console.WriteLine (@acc_chr);
//			System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match (name, @"(?<accidential>["+@acc_chr+@"]*)(?<degree>[1-9][0-9]?)");

			System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match (name, @"(?<accidential>[+|\-|#|b|♯|♭]*)(?<degree>[1-9][0-9]?)");
			int d = int.Parse (match.Groups ["degree"].Value);
			System.Console.WriteLine ("deg:" + d);
			System.Console.WriteLine ("a_s:" + match.Groups ["accidential"].Value);
			int a = Accidental.GetPitch(match.Groups ["accidential"].Value);
			System.Console.WriteLine ("acc:" + a);
			this.Pitch = Degree.Pitchs [d] + a;
			System.Console.WriteLine ("pit:" + this.Pitch);
			this.Name = name;
		}
	}
}

