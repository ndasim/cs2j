using System;
namespace cs2jTest.Various.Features.join.yield
{
	
	// delegate declaration
	public delegate string MyDelegate(int i);

	public class Various
	{
		public Various ()
		{
		}
		
		public const int MY_IMPORTANT_INT = 23;
		public const String MY_IMPORTANT_STRING = "Kevin";
		
		private System.Collections.Generic.IDictionary<int,short> myDict;
		
		public string TestRWProperty {get; set;}
		
		public string get_TestRWProperty() {
			return "hello";
		}
		
		public string testgen<T>(T i) {
			return "hello";
		}
			
		private string _testROProperty = null;
		public string TestROProperty {
			get { return _testROProperty; }
		}
		private string _testWOProperty = null;	
		public string TestWOProperty {
			set { _testWOProperty = value;}
		}
		
		public static explicit operator Various(int i)
    	{
        	return new Various();
    	}

		public static implicit operator Various(string i)
    	{
        	return new Various();
    	}

		public static explicit operator bool(Various v)
    	{
        	return true;
    	}

		public static implicit operator string(Various v)
    	{
        	return "Various";
    	}

		
	}
}

