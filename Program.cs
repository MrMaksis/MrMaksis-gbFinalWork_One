string[] FindResultArray(string[] arr)                  //Функция отбора массиива
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