//Функция отбора элементов массиива
string[] FindResultArray(string[] arr)
{
    string[] outArr = new string[arr.Length];
    int count = 0;

    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            outArr[count] =  arr[i];
            count++;
        }
    }

    //Записывает число количества непустых элементов
    outArr[outArr.Length - 1] = count.ToString();                   
    return outArr;
} 

//Функция вывода массива
void PrintArray(string[] arr){ 

    //Цикл вывода непустых элементов массива
    for(int i = 0; i < Convert.ToInt32(arr[arr.Length - 1]); i++){
        Console.Write($"{arr[i]} : ");
    }
} 

string[] arr = {"wdwd2", "dwd1","0","1","123"};

PrintArray(FindResultArray(arr));