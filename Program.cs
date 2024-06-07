
class Program{
  static void Main(){
    int a = 10;
    int b = 20;
    int c = 30;
    int temp;

    if(a>b){
      temp = a;
    }else{
      temp = b;
    }

    if(temp<c){
      temp = c;
    }

    Console.WriteLine("Largest Number : "+temp);
  }
}