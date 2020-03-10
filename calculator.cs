class calculator
{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.Writeline("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.Writeline("Hasil pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.Writeline("\nTekan sembarang key untuk keluar");
		Console.Readkey();
	}
	
	static int penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a - b;
	}
}