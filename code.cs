public override void WriteHeaders ()
		{
			headers.WriteLine ();
			headers.WriteLine ("/** This override the default hashing computation (defined in NSObject Protocol)");
			headers.WriteLine (" * https://developer.apple.com/reference/objectivec/1418956-nsobject/1418859-hash?language=objc");
			headers.WriteLine (" */");
			base.WriteHeaders ();
		}

#if DEBUG
			Entries.Add (line);
#endif
		}

		public static void Dump ()
		{
#if DEBUG
			Entries.ForEach (l => Console.WriteLine (l));
#endif
		}
	}
}
//hello
