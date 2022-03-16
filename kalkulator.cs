class Calculator
{
	static void main (string []agrs){
		int a = 20;
		int b = 2; //Tugas 4

	    Console.WriteLine("Hasil pengurangan {0} + {1} = {2}",a ,b, Pengurangan(a,b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}",a ,b, Pengurangan(a,b));

            Console.WriteLine("\n Tekan sembarang tombol untuk keluar");
            Console.ReadKey();
	}
	static int Penambahan(int a, int b){
		return a + b; //Tugas 2
	}
	static int Pengurangan(int a, int b){
		return a - b; //Tugas 3
		
	}
}
